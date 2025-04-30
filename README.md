# Aplicação de Gerenciamento de Pessoas

Este projeto consiste em uma aplicação dividida em duas partes: uma API RESTful em C# (.NET 9) e um frontend em Angular 19. O sistema exibe uma lista paginada de pessoas com funcionalidades de filtragem por nome.

## Requisitos

### Back-end
- .NET 9 SDK
- Visual Studio 2022 ou Visual Studio Code

### Front-end
- Node.js (versão 18.19+ ou 20.11+ ou 22+)
- npm (gerenciador de pacotes do Node.js)
- Angular CLI versão 19.2.10 ou superior

## Estrutura do Projeto

O projeto está dividido em duas partes principais:

### People.API (Back-end)
Aplicação ASP.NET Core que fornece uma API RESTful com os seguintes componentes:
- **Controllers**: Controladores que expõem endpoints da API
- **Models**: Definições das entidades utilizadas no sistema

### People.Frontend (Front-end)
Aplicação Angular que consome a API e exibe os dados:
- **Components**: Componentes visuais da aplicação
- **Models**: Interfaces TypeScript que definem a estrutura de dados
- **Services**: Serviços para comunicação com a API

## Instalação e Execução

### Back-end (People.API)

1. Navegue até a pasta do projeto da API:
```bash
cd People.API
```

2. Restaure os pacotes NuGet:
```bash
dotnet restore
```

3. Execute a aplicação:
```bash
dotnet run
```

A API estará disponível em `http://localhost:5258`.

### Front-end (People.Frontend)

1. Navegue até a pasta do projeto do frontend:
```bash
cd People.Frontend
```

2. Instale as dependências:
```bash
npm install
```

3. Execute a aplicação:
```bash
ng serve
```

O frontend estará disponível em `http://localhost:4200`.

## Funcionalidades

### API (Back-end)

A API fornece os seguintes endpoints:

- `GET /api/pessoas`: Retorna uma lista mockada com 30 registros de pessoas contendo os campos:
  - Cpf (string)
  - Nome (string)
  - Genero (string)
  - Endereco (string)
  - Idade (int)
  - Municipio (string)
  - Estado (string)

### Frontend (Angular)

O frontend apresenta:

1. **Tabela de Pessoas**:
   - Exibição de todos os campos disponíveis na API
   - Paginação limitada a 10 registros por página
   - Botões para navegar entre as páginas

2. **Filtro por Nome**:
   - Campo de busca que filtra os resultados por nome em tempo real

3. **Botão de Carregamento**:
   - Botão para carregar os dados da API

## Utilização

1. Inicie tanto o back-end quanto o front-end seguindo as instruções acima.
2. Abra seu navegador e acesse `http://localhost:4200`.
3. Clique no botão "Carregar Dados" para buscar a lista de pessoas da API.
4. Use o campo de filtro para encontrar pessoas por nome.
5. Utilize a paginação na parte inferior da tabela para navegar entre as páginas de resultados.

## Resolução de Problemas Comuns

### CORS
Se encontrar problemas de CORS, verifique se:
- A API está sendo executada em `http://localhost:5258`
- A configuração CORS no arquivo `Program.cs` da API está correta

### Conexão Recusada
Se o frontend não conseguir se conectar à API:
- Verifique se a API está em execução
- Confirme que a URL da API no arquivo `src/app/services/pessoa.service.ts` está correta

### Problemas de Dependências
Se encontrar erros relacionados a pacotes:
- Execute `npm install` novamente no diretório do frontend
- Execute `dotnet restore` no diretório da API

## Desenvolvimento

### Extendendo a API
Para adicionar novos endpoints ou funcionalidades à API:
1. Crie ou modifique os controladores em `People.API/Controllers/`
2. Adicione ou modifique os modelos em `People.API/Models/`

### Extendendo o Frontend
Para adicionar novas funcionalidades ao frontend:
1. Crie novos componentes usando o Angular CLI:
```bash
ng generate component novo-componente
```
2. Adicione ou modifique serviços para comunicação com a API:
```bash
ng generate service novo-servico
```

## Tecnologias Utilizadas

### Back-end
- ASP.NET Core 9
- C#
- Swagger para documentação da API

### Front-end
- Angular 19
- TypeScript
- Angular Material para componentes de UI
- RxJS para programação reativa
