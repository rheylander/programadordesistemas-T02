# Login While — C# Windows Forms

Aplicação acadêmica desenvolvida em C# para praticar validação de dados, estruturas condicionais, eventos de interface e controle de tentativas de acesso.

## Objetivo

Criar uma tela de login simples com credenciais fictícias e limite de três tentativas incorretas.

O projeto não representa um sistema de autenticação real. As credenciais ficam armazenadas no próprio código apenas para fins didáticos.

## Funcionalidades

- Campo de e-mail;
- Campo de senha com ocultação dos caracteres;
- Botão Entrar;
- Execução do login pela tecla Enter;
- Mensagem de sucesso quando os dados estão corretos;
- Contagem de tentativas restantes;
- Bloqueio da tela após três erros;
- Desativação dos campos e do botão após o bloqueio;
- Janela fixa, centralizada e sem maximizar ou minimizar.

## Credenciais de teste

- E-mail: `usuario@teste.com`
- Senha: `senha123`

Esses dados são fictícios e existem somente para testar o fluxo da aplicação.

## Regras do sistema

1. O usuário informa e-mail e senha.
2. Se os dois valores coincidirem com as credenciais de teste, o acesso é liberado.
3. Se houver erro, uma tentativa é contabilizada.
4. Após três tentativas incorretas, a tela é bloqueada.
5. A tecla Enter executa a mesma ação do botão Entrar por meio do `AcceptButton` do formulário.

## Conceitos praticados

- Variáveis;
- Estruturas condicionais com `if` e `else`;
- Constantes;
- Eventos de botão;
- Propriedades de controles;
- Validação de entrada;
- Controle de estado da interface;
- Uso básico de Windows Forms.

## Estrutura principal

- `Form1.cs` — regras e comportamento do formulário;
- `Form1.Designer.cs` — controles e configuração visual;
- `Program.cs` — ponto de entrada da aplicação;
- `App.config` — configuração do projeto;
- `LoginWhileWinForms.csproj` — definição do projeto.

## Tecnologias

- C#;
- Windows Forms;
- .NET Framework 4.7.2;
- Visual Studio;
- Git e GitHub.

## Como executar

1. Abra o arquivo de solução ou o projeto no Visual Studio.
2. Confirme que o .NET Framework 4.7.2 está disponível no ambiente.
3. Compile e execute a aplicação.
4. Teste um login correto.
5. Teste credenciais incorretas até o bloqueio.
6. Teste também a tecla Enter.

## Limites atuais

O projeto é um exercício acadêmico. Ele não utiliza banco de dados, criptografia, cadastro de usuários ou autenticação segura. As credenciais são fixas e servem somente para demonstrar o fluxo de validação.

## Aprendizados

O projeto ajudou a compreender como uma aplicação desktop recebe entradas, valida condições, altera o estado de seus controles e orienta o usuário por meio de mensagens.
