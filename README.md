# David Wang · Portfolio

My personal portfolio site, designed in Figma and built from scratch. It has a React and TypeScript front end and an ASP.NET Core 10 back end. The back end reads the site's content from a PostgreSQL database, supplies it through a small REST API, and serves the built front end.

I built it to learn React and TypeScript, and to show how I approach a full-stack project from design through to deployment.

**Live site: [daviidwang.dev](https://daviidwang.dev)**

## What's on the site

| Page | Content |
| --- | --- |
| Home | Introduction and current role |
| Projects | Work experience and selected projects |
| Skills | Tools grouped by area, each tied to where I've used it |
| Education | Degrees, scholarship, university projects and coursework |
| Contact | Email, LinkedIn, GitHub and what I'm looking for |

## Tech stack

**Front end:** React 19, TypeScript, React Router, Vite, plain CSS (no UI framework)

**Back end:** ASP.NET Core 10 Web API, C#, Entity Framework Core 10

**Database:** PostgreSQL, hosted on [Neon](https://neon.tech) (free plan)

**Tooling:** Prettier, oxlint, `dotnet format`, Figma for design

**Hosting:** Azure App Service, deployed with GitHub Actions, custom domain via Cloudflare DNS

## How it works

```text
Browser ──► React app (client/)
              │  fetch /api/...
              ▼
           ASP.NET Core API (server/)
              ├─ /api/experience
              ├─ /api/projects
              ├─ /api/skillgroups
              └─ /api/education
              │  Entity Framework Core
              ▼
           PostgreSQL (Neon)
```

- **Content lives in the database.** Each controller queries PostgreSQL through Entity Framework Core and returns the results as JSON. The client has matching TypeScript types in `client/src/types.ts`, so both sides agree on the shape of the data.
- **Two database branches.** Neon's `production` branch holds the live site's content. A `dev` branch is used for local development, so experiments never touch the live site.
- **Starting content is seeded once.** `server/Data/SeedData.cs` holds the initial content. It is loaded when migrations are applied to an empty database, and never overwrites existing data. After that, content is edited directly in the database.
- **One server in production.** The React app is built into `server/wwwroot`. ASP.NET Core serves those files (pre-compressed with Brotli and gzip) and returns `index.html` for any other route, so client-side routes like `/skills` still work when you refresh the page or open them directly. Unknown `/api` routes return 404.
- **Two servers in development.** Vite serves the front end with hot reload and forwards `/api` requests to the .NET server on port 5082.

## Project structure

```text
client/                 React + TypeScript app (Vite)
  src/
    pages/              One component per route
    components/         Shared UI: nav bar, cards, footer
    types.ts            Types matching the API's JSON
server/                 ASP.NET Core 10 API
  Controllers/          One controller per endpoint
  Data/                 DbContext, seed content and EF Core migrations
  Models/               Entity classes stored in the database and returned by the API
  Portfolio.Api.http    Requests for testing the API from the editor
.github/workflows/      GitHub Actions deployment to Azure
package.json            Root script that runs both servers together
```

## Running locally

**Prerequisites:** [Node.js](https://nodejs.org/) 20.19 or later and the [.NET 10 SDK](https://dotnet.microsoft.com/download).

Install dependencies once:

```bash
npm install                 # root: tools to run both servers together
npm install --prefix client # front end
```

The API needs a PostgreSQL connection string named `Portfolio`. It is kept in .NET user secrets, outside the repository. Run this once from `server/`, using a Neon branch's .NET connection string (or any PostgreSQL database):

```bash
dotnet user-secrets set "ConnectionStrings:Portfolio" "Host=...;Database=...;Username=...;Password=...;SSL Mode=Require"
```

To create the tables and load the starting content into that database:

```bash
dotnet tool install --global dotnet-ef   # once
cd server && dotnet ef database update
```

Start the API and the front end together from the root folder:

```bash
npm run dev
```

This starts the API on `http://localhost:5082` and waits for it to respond before starting Vite. Open the URL that Vite prints, usually `http://localhost:5173`.

To run them separately instead:

```bash
cd server && dotnet run     # API
cd client && npm run dev    # front end, in a second terminal
```

## Useful commands

| Where | Command | What it does |
| --- | --- | --- |
| `client/` | `npm run build` | Type-checks and builds the production front end |
| `client/` | `npm run lint` | Lints with oxlint |
| `client/` | `npm run format` | Formats with Prettier |
| `server/` | `dotnet format` | Formats the C# code |

## Deployment

The site runs on a single Azure App Service (Linux, .NET 10) at [daviidwang.dev](https://daviidwang.dev). Every push to `main` triggers the [deploy workflow](.github/workflows/deploy.yml), which:

1. Runs `npm ci` and `npm run build` in `client/`, building the React app into `server/wwwroot`.
2. Runs `dotnet publish -c Release`, which bundles the API with `wwwroot`.
3. Runs `dotnet ef database update` against the production database, applying any new migrations. If this fails, the deploy stops and the live site keeps running the previous version.
4. Deploys the published output to App Service.

The workflow can also be run manually from the **Actions** tab.

The live site reads its connection string from an App Service connection string named `Portfolio`. The workflow uses a separate, non-pooled connection string stored in the `NEON_MIGRATION_CONNECTION` GitHub secret.

## Updating content

Content is edited directly in the database, using Neon's **Tables** view or **SQL Editor**. Make the change on the `dev` branch first and check it locally, then repeat it on `production`. Changes appear on the live site straight away, with no deploy needed.

Editing `SeedData.cs` does not change an existing database. Keep it in step with the database anyway, so a new database starts with current content.

| Change | How |
| --- | --- |
| Content (text, lists, new items) | Edit in Neon, then mirror the change in `SeedData.cs` |
| Shape of the data (new fields or tables) | Change the classes in `Models/`, run `dotnet ef migrations add <Name>`, then push. The deploy applies the migration. |

The domain is registered with Cloudflare, which points `daviidwang.dev` and `www.daviidwang.dev` at App Service through DNS. HTTPS uses free App Service managed certificates that renew automatically.

## Contact

- LinkedIn: [linkedin.com/in/david-wang-2b9931248](https://www.linkedin.com/in/david-wang-2b9931248/)
- GitHub: [github.com/daviid-wang](https://github.com/daviid-wang)
