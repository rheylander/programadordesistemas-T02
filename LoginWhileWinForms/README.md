# LoginWhileWinForms

Projeto desenvolvido em **C# com Windows Forms (.NET Framework)** para simular um sistema de login com controle de tentativas.

## Objetivo

Criar uma tela de login simples e funcional que permita ao usuário informar e-mail e senha, validando os dados e limitando o acesso a no máximo **3 tentativas**.

## Funcionalidades

- Campo para digitação de e-mail
- Campo para digitação de senha
- Botão **Entrar**
- Validação de login com dados fictícios
- Mensagem de sucesso ao acertar
- Contagem de tentativas restantes ao errar
- Bloqueio do acesso após 3 tentativas incorretas
- Execução do login também pela tecla **Enter**

## Regras do sistema

O sistema utiliza credenciais fictícias armazenadas em variáveis no código:

- **E-mail:** `usuario@teste.com`
- **Senha:** `senha123`

### Comportamento

- Se o e-mail e a senha estiverem corretos, o sistema exibe:
  - **Login bem-sucedido**
- Se estiverem incorretos:
  - o sistema informa o erro
  - reduz a quantidade de tentativas restantes
- Ao atingir o limite de 3 erros:
  - a conta é bloqueada
  - os campos e o botão de login são desativados

## Conceitos praticados

Este projeto foi desenvolvido para praticar:

- Variáveis
- Estruturas condicionais (`if` e `else`)
- Eventos de botão no Windows Forms
- Propriedades de controles
- Validação de dados
- Controle de tentativas de acesso
- Interface gráfica com WinForms

## Estrutura do projeto

Os principais arquivos do projeto incluem:

- `Form1.cs`
- `Form1.Designer.cs`
- `Program.cs`
- `App.config`
- `LoginWhileWinForms.csproj`

## Tecnologias utilizadas

- **C#**
- **Windows Forms**
- **.NET Framework**
- **Visual Studio**

## Como executar

1. Clone este repositório
2. Abra a solução no Visual Studio
3. Execute o projeto
4. Informe o e-mail e a senha na tela de login

## Aprendizados

Com este projeto, foi possível praticar a criação de interfaces gráficas em Windows Forms, além de compreender melhor como funciona a validação de login, o tratamento de tentativas e a interação do usuário com eventos em aplicações desktop.

## Autor

**Rheylander Soares**
