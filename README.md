# Calculadora Simples

## Descrição do Projeto
Este é um projeto de uma aplicação de console simples desenvolvida em **C#** que simula uma calculadora básica. A calculadora permite realizar as seguintes operações matemáticas:

- Soma
- Subtração
- Multiplicação
- Divisão

O programa valida as entradas, lida com erros como divisões por zero e permite que o usuário execute múltiplas operações em um loop contínuo até decidir sair.

---

## Funcionalidades

1. **Validação de Entrada**:
   - Os números digitados pelo usuário são validados para garantir que sejam valores numéricos válidos.

2. **Operações Matemáticas**:
   - Soma: Adiciona dois números.
   - Subtração: Subtrai o segundo número do primeiro.
   - Multiplicação: Multiplica dois números.
   - Divisão: Divide o primeiro número pelo segundo, desde que o divisor não seja zero.

3. **Loop Contínuo**:
   - O programa permanece em execução até que o usuário escolha a opção de sair.

4. **Interface Simples**:
   - Menu de opções para escolher a operação desejada.
   - Exibição clara dos resultados.
---

## Como Executar o Projeto

1. **Pré-requisitos**:
   - .NET SDK instalado (versão 8.0 ou superior).

2. **Clone o repositório**:
   ```bash
   git clone <URL_DO_REPOSITORIO>
   cd CalculadoraSimples
   ```

3. **Execute o projeto**:
   ```bash
   dotnet run
   ```

4. Siga as instruções no console para realizar cálculos.

---

## Melhorias Implementadas

- **Validação de entrada com `double.TryParse`**:
  - Garante que os valores digitados pelo usuário sejam válidos antes de realizar as operações.

- **Loop para continuar**:
  - O programa permanece em execução até que o usuário escolha sair.

- **Modularização**:
  - Métodos separados para as operações matemáticas (`Soma`, `Subtracao`, `Multiplicacao`, `Divisao`).
  - Métodos auxiliares para leitura de números e exibição de resultados.

---

## Contribuições
Contribuições são bem-vindas! Se você tiver ideias para novas funcionalidades ou melhorias, sinta-se à vontade para abrir uma issue ou enviar um pull request.

---

## Licença
Este projeto está licenciado sob a licença MIT. Consulte o arquivo `LICENSE` para mais informações.

---

## Contato
Gabriel Costa - [LinkedIn](https://www.linkedin.com/in/seu-perfil)

