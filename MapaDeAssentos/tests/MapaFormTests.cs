using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MatrizesWinFormsAssentos;

internal static class MapaFormTests
{
    private static int total;
    private static object Field(Form1 form, string name)
    {
        return typeof(Form1).GetField(name, BindingFlags.NonPublic | BindingFlags.Instance).GetValue(form);
    }
    private static object Call(Form1 form, string name, params object[] args)
    {
        return typeof(Form1).GetMethod(name, BindingFlags.NonPublic | BindingFlags.Instance).Invoke(form, args);
    }
    private static bool Import(Form1 form, string[] text)
    {
        object[] args = { text, null };
        return (bool)Call(form, "TryImportarMapaCsv", args);
    }
    private static void Check(bool ok, string message)
    {
        total++;
        if (!ok) throw new Exception(message);
    }
    [STAThread]
    public static void Main()
    {
        using (Form1 form = new Form1())
        {
            form.Show();
            Application.DoEvents();
            Check(Import(form, new[] { "2;2", "0;1", "2;0" }), "Importacao valida");
            Button[,] buttons = (Button[,])Field(form, "_botoes");
            Check(buttons[0,1].Text == "R" && buttons[0,1].BackColor == Color.LightGreen, "Visual reservado");
            Check(buttons[1,0].Text == "X" && buttons[1,0].BackColor == Color.LightGray, "Visual bloqueado");
            Check(((Label)Field(form, "lblLivres")).Text == "Livres: 2", "Contador livres");
            Check(((Label)Field(form, "lblReservados")).Text == "Reservados: 1", "Contador reservados");
            Check(((Label)Field(form, "lblBloqueados")).Text == "Bloqueados: 1", "Contador bloqueados");
            ((RadioButton)Field(form, "rbReservar")).Checked = true;
            Call(form, "Celula_Click", buttons[0,0], EventArgs.Empty);
            Check(buttons[0,0].Text == "R", "Reserva pelo evento da interface");
            object previous = Field(form, "_mapa");
            string[] before = (string[])Call(form, "ExportarMapaCsv");
            Check(!Import(form, new[] { "2;2", "0;0", "0;9" }), "Rejeita erro tardio");
            Check(object.ReferenceEquals(previous, Field(form, "_mapa")) &&
                object.ReferenceEquals(buttons, Field(form, "_botoes")), "Preserva mapa e botoes");
            Check(string.Join("\n", before) == string.Join("\n", (string[])Call(form, "ExportarMapaCsv")), "Preserva reservas");
            Check(((Label)Field(form, "lblReservados")).Text == "Reservados: 2" &&
                buttons[0,0].Text == "R", "Preserva contador e visual");
            Check(!Import(form, new[] { "31;2" }) && object.ReferenceEquals(previous, Field(form, "_mapa")), "Rejeita dimensao excessiva sem alterar mapa");
            Check(Import(form, new[] { "2;3", "1;0;2", "0;1;0" }), "Importa novo tamanho");
            Check(((NumericUpDown)Field(form, "nudLinhas")).Value == 2 &&
                ((NumericUpDown)Field(form, "nudColunas")).Value == 3, "Sincroniza seletores");
            Check(((Label)Field(form, "lblLivres")).Text == "Livres: 3" &&
                ((Label)Field(form, "lblReservados")).Text == "Reservados: 2" &&
                ((Label)Field(form, "lblBloqueados")).Text == "Bloqueados: 1", "Contadores apos novo tamanho");
            string path = Path.GetTempFileName();
            try
            {
                string[] saved = (string[])Call(form, "ExportarMapaCsv");
                File.WriteAllLines(path, saved);
                Call(form, "LimparMapa");
                Check(Import(form, File.ReadAllLines(path)), "Reabre arquivo salvo");
                Check(string.Join("\n", saved) == string.Join("\n", (string[])Call(form, "ExportarMapaCsv")), "Roundtrip dos estados");
            }
            finally { File.Delete(path); }
            form.Close();
        }
        Console.WriteLine("PASS: " + total + " WinForms integration tests");
    }
}
