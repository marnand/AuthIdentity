# AuthIdentity 
# Autenticação e autorização com Identity, Jwt e AutoMapping

API RESTful de login, arquitetura em camadas com DDD, injeção de dependência e entity frameworkCore. 
Este projeto utiliza .NET 5 versão SDK 5.0.403. 

DDD em .NET: <br />
https://www.devmedia.com.br/introducao-ao-ddd-em-net/32724 

Injeção de Dependência: <br /> 
http://www.macoratti.net/19/04/c_dioc1.htm

Entity Framework: <br />
http://www.macoratti.net/09/06/vb_iaef.htm 
https://medium.com/@ericandrade_24404/parte-02-criando-arquitetura-em-camadas-com-ddd-inje%C3%A7%C3%A3o-de-dep-ef-defac0005667
<br /><br />


# Criação do projeto - dotnet CLI

dotnet new webapi -o NomeDoProjeto
<br /><br />


# Pacotes 

Adicionando pacotes (dotnet CLI):
<p>
<b>dotnet add package NomeDoPacote </b> <i> -v 0.0.0</i> (a versão é opcional, mas em caso de incompatibilidade escolha a versão mais adequeada para o seu projeto)
</p>

Nome dos pacotes utilizados: <br />
Microsoft.AspNetCore.Identity <i>versão 2.2.0</i><br />
Microsoft.IdentityModel.Tokens <i>versão 6.14.1</i><br />
System.IdentityModel.Tokens.Jwt <i>versão 6.14.1</i><br />
Microsoft.AspNetCore.Authentication <i>versão 2.2.0</i> <br />
Microsoft.AspNetCore.Authentication.JwtBearer <i>versão 5.0.12</i> <br />

Microsoft.EntityFrameworkCore <i>versão 5.0.12 </i><br />
Microsoft.EntityFrameworkCore.Tools <i>versão 5.0.12</i> <br />
Microsoft.EntityFrameworkCore.Design <i>versão 5.0.12</i><br />
Microsoft.EntityFrameworkCore.SQLite <i>versão 5.0.12</i><br />
Microsoft.AspNetCore.Identity.EntityFrameworkCore <i>versão 5.0.12</i> <br />

AutoMapper.Extensions.Microsoft.DependencyInjection <i>versão 8.1.1</i><br /><br/>


# Referenciando na solução - dotnet CLI

dotnet sln ../AuthIdentity.sln add AuthIdentity.API.csproj <br />
dotnet sln ../AuthIdentity.sln add AuthIdentity.Application.csproj <br />
dotnet sln ../AuthIdentity.sln add AuthIdentity.Domain.csproj <br />
dotnet sln ../AuthIdentity.sln add AuthIdentity.Persistence.csproj
<br /><br />


# Criando migrations e banco de dados - dotnet CLI
<p>
Utilizei o banco de dados SQLite, que gera apenas um arquivos no projeto, ideal para projetos pequenos, estudos e testes. Possibilita ter acesso a banco de dados SQL sem executar um processo SGBD separado.
</p>

SQLite - o pequeno e notável: <br />
https://www.devmedia.com.br/sqlite-o-pequeno-notavel/7249

dotnet ef migrations add Nome-Migration -p <i>AuthIdentity.Persistence</i> -s <i>AuthIdentity.API</i> <br />
<b>AuthIdentity.Persistence</b> é projeto onde está a referência para tabelas. <br />
<b>AuthIdentity.API</b> é projeto onde está o <b>Startup.cs</b>.

dotnet ef database update -s AuthIdentity.API
<br /><br />


# Rodando projeto - dotnet CLI

dotnet watch run

<p align='right'>
*CLI - Command Line Interface (Interaface de linha de comando)
</p>