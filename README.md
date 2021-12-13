<h1 align="center">PolenCharityDonationAPI</h1>


[![nosso site](https://img.shields.io/badge/nosso%20site-polen-%23413279)](https://polen.com.br/)
[![nosso site](https://img.shields.io/badge/nuget-v13.0.1-blue)](https://www.nuget.org)
[![nosso site](https://img.shields.io/badge/helper-polen--dev-%239653a1)](https://polen-donation.github.io/polen-docs/)


<h2 align="center">A sua API de doações.</h2>

A instalação da PolenAPI é feita de forma simples conforme os passos descritos a seguir.

## Sobre

A Polen é uma empresa especializada em intermediar doações corporativas entre empresas e instituições brasileiras do terceiro setor e em gerar transparência das doações.

## Requisitos

- Versão do dotnet: Deve ser 3.1 ou superior (que pode ser verificado executando`dotnet --version`).

## Instalação

A maneira mais fácil de instalar a PolenAPI é usar a ferramenta de linha de comando. Você pode executar este comando em qualquer lugar em um novo repositório ou dentro de um repositório existente.
Você pode encontrar essa e várias outras bibliotecas em nossos [repositórios](https://github.com/Polen-Donation/PolenCharityDonationAPI).
```shell
dotnet add package Polen.Charity.Donation.Api.Json --version
```

## Como usar
Após a instalação você pode fazer a importação para o seu projeto através do `require` e fazer uma instância da classe `polen_charity_donation_api` passando um token de acesso. Esse token pode ser encontrado no [painel do polinizador](https://painel.opolen.com.br/).


```csharp
using Polen.Charity.Donation.Api;

public class MyClass {
    PolenApi polen = new Polen.Api("token");
}
```

## Como conseguir o seu Token
Acesse sua conta no nosso [painel](https://painel.polen.com.br/#/pages/login) ou crie uma nova [conta](https://bemvindo.opolen.com.br/#/customization). Após acessar vá no menu do canto superior direito, clique em **API** e depois é só copiar o conteúdo do campo **Token**.

## Métodos

Você pode consultar nossa [documentação](https://polen-donation.github.io/polen-docs/docs/) e verificar todos os métodos disponíveis.

- [Causes](https://polen-donation.github.io/polen-docs/docs/C#/methods/cause): Métodos que permitem consultas de causas;
- [Company](https://polen-donation.github.io/polen-docs/docs/C#/methods/company): Métodos que listam empresas, criam empresas, atualizam dados da empresa e listam lojas associadas a uma empresa;
- [Donation Direct](https://polen-donation.github.io/polen-docs/docs/C#/methods/donation-direct): Método que cria uma doação direta;
- [Finance](https://polen-donation.github.io/polen-docs/docs/C#/methods/finance): Método que retorna todas as suas faturas de pagamento;
- [Donation Notify](https://polen-donation.github.io/polen-docs/docs/C#/methods/notify-donation): Métodos que listam doações feitas, retornam detalhes de uma doação, atualizam status de uma doação e criam uma nova doação associada a uma loja;
- [Platform](https://polen-donation.github.io/polen-docs/docs/C#/methods/platform):  Método que retorna todas as plataformas parceiras que o Polen já possui integração nativa;
- [Store](https://polen-donation.github.io/polen-docs/docs/C#/methods/store): Métodos que listam lojas, criam novas lojas, editam lojas existentes e adicionam/removem causas da loja;
- [Transaction](https://polen-donation.github.io/polen-docs/docs/C#/methods/transaction): Método para o informar o estado de uma compra;
- [Transparency](https://polen-donation.github.io/polen-docs/docs/C#/methods/transparency): Métodos que permitem a consulta de listas de conteúdos disponibilizados pelas ongs, detalhes de um conteúdo, recibos de doações e um considado do total doado;
- [User](https://polen-donation.github.io/polen-docs/docs/C#/methods/user): Métodos que permitem a consulta de detalhes de um usuário, lista de usuários de uma loja, criar usuários, deletar usuários, associar usuários a causas;

## Ajuda

- Acesse nossa [documentação](https://polen-donation.github.io/polen-docs/) e conheça melhor nossa lib.

- Ainda com dúvida? Entre em contato pelo nosso [canal do discord](https://discord.gg/6YVtUbKS4b), vamos ter o prazer de ajudar você!