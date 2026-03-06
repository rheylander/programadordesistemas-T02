# Mapa de Assentos — Matrizes (Windows Forms .NET Framework)

## Objetivo
Desenvolver um programa em **C# (Windows Forms .NET Framework)** que trabalhe com **matrizes (arrays 2D)**, aplicando conceitos de programação e **versionamento de código (Git/GitHub)**.

Este projeto simula um **mapa de assentos** (como cinema, ônibus ou sala) onde cada assento possui um estado:
- **Livre**
- **Reservado**
- **Bloqueado**

---

## Tecnologias
- **C#**
- **Windows Forms (.NET Framework)**
- **Visual Studio 2022**
- **Git/GitHub**

---

## Conceito de Matriz (Array 2D) no projeto
O sistema utiliza uma **matriz bidimensional** para representar os assentos:

- `SeatState[,] _mapa`

Onde:
- `linha` = índice da linha do grid
- `coluna` = índice da coluna do grid
- `_mapa[linha, coluna]` = estado do assento naquela posição

### Estados possíveis (enum)
- `0 = Livre`
- `1 = Reservado`
- `2 = Bloqueado`

Além disso, é usada uma segunda matriz para guardar os botões da interface:
- `Button[,] _botoes`

Isso permite atualizar rapidamente o visual de cada assento.

---

## Funcionalidades
✅ Gerar o grid com quantidade de **Linhas** e **Colunas** configuráveis  
✅ Alterar estado do assento com base no **Modo** selecionado  
✅ Contadores no rodapé: **Livres | Reservados | Bloqueados**  
✅ **Salvar** o mapa em arquivo **CSV**  
✅ **Carregar** o mapa a partir de arquivo **CSV**  
✅ **Limpar** o mapa (reset para Livre)

---

## Como usar
1. Defina o número de **Linhas** e **Colunas** (NumericUpDown).
2. Clique em **Gerar Grid** para criar o mapa.
3. Escolha um **Modo**:
   - **Reservar/Cancelar**: alterna entre Livre ↔ Reservado  
   - **Bloquear**: define como Bloqueado  
   - **Liberar**: define como Livre
4. Clique em um assento (botão do grid) para aplicar a ação.
5. Use:
   - **Salvar (CSV)** para exportar o estado atual
   - **Carregar (CSV)** para importar um mapa salvo
   - **Limpar** para zerar o mapa

---

## Regras de negócio aplicadas
- Um assento **Bloqueado** não pode ser reservado diretamente.
  - Para mudar um bloqueado, é necessário usar **Liberar**.
- O modo **Reservar/Cancelar** alterna automaticamente:
  - Livre → Reservado  
  - Reservado → Livre

---

## Formato do arquivo (CSV)
O arquivo salvo segue este padrão (sem JSON):

**Linha 1:** `linhas;colunas`  
**Linhas seguintes:** valores separados por `;` com `0`, `1` ou `2`

Exemplo:
```csv
3;4
0;0;1;0
2;0;0;0
0;1;0;2
