<div align="center">
  <h1>Nex_TI – EdTech Learning Platform</h1>
  <p><strong>Projeto Integrado Multidisciplinar (PIM III) — Análise e Desenvolvimento de Sistemas — UNIP</strong></p>

  <img src="https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white" alt="HTML5"/>
  <img src="https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white" alt="CSS3"/>
  <img src="https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black" alt="JavaScript"/>
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#"/>
  <img src="https://img.shields.io/badge/.NET_10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 10"/>
  <img src="https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="SQL Server"/>
  <img src="https://img.shields.io/badge/Figma-F24E1E?style=for-the-badge&logo=figma&logoColor=white" alt="Figma"/>
  <img src="https://img.shields.io/badge/UML-Astah_10.1-orange?style=for-the-badge" alt="Astah"/>
</div>

---

## 📂 Estrutura

Este é o repositório único do PIM III. As três frentes do projeto, antes separadas em
repositórios distintos, vivem aqui como pastas de primeiro nível:

```text
📁 PIM_III/
├── 📁 teorica/     # Monografia ABNT interativa (HTML/CSS), protótipos, cronogramas e atas
├── 📁 pratica/     # Implementação: frontend HTML/CSS/JS, API C# (.NET 10) e script SQL Server
├── 📁 uml/         # Modelagem UML (Astah), diagramas exportados e backlog do produto
├── 📁 .agents/     # Skills e instruções de agentes de IA, compartilhadas pelas três frentes
├── 📁 .vscode/     # Configuração do editor para o workspace inteiro
└── 📄 .gitattributes, .gitignore, LICENSE
```

### Por frente

| Pasta | Conteúdo |
|---|---|
| [`teorica/`](teorica) | Relatório ABNT em HTML/CSS (`index.html`), `assets/`, `design_DNA/`, `docs/` (PDFs entregues) e `examples/` |
| [`pratica/`](pratica) | `index.html` + `pages/` + `assets/` (frontend), `backend/` (API .NET), `database/` e os manuais de execução, prático e técnico |
| [`uml/`](uml) | `01_Documentacao_Teorica/`, `02_Modelagem_UML/` (fonte `.asta` + PNGs), `03_Codigo_Gerado/` |

## 📖 Como abrir o relatório

Abra [`teorica/index.html`](teorica/index.html) no navegador, ou use a extensão Live Server
do VS Code (porta `5501`, já configurada em `.vscode/settings.json`).

## 🚀 Como executar a parte prática

1. Rode `pratica/database/NexTI_DB.sql` no SQL Server.
2. Na pasta `pratica/backend/`, execute `dotnet restore` e `dotnet run`.
3. Abra `pratica/index.html` com o Live Server.

Detalhes de conexão, portas e API estão em [`pratica/MANUAL_DE_EXECUCAO.md`](pratica/MANUAL_DE_EXECUCAO.md).

## 🧬 Histórico

Este repositório foi formado a partir de três repositórios anteriores, com o histórico de
commits preservado via `git subtree`:

- `PIM_III-Parte_Teorica` → `teorica/`
- `PIM_III-Documentacao_UML` → `uml/`
- `PIM_IV-Parte_Pratica` até o commit `6128628` → `pratica/`

A parte prática do PIM III não tinha repositório próprio no GitHub: o código foi publicado no
`PIM_IV-Parte_Pratica`, que seguiu evoluindo no semestre seguinte. A pasta `pratica/` traz
somente o histórico até `6128628`, o último commit antes das mudanças do PIM IV (simulados
ENADE, novos endpoints e troca das referências para PIM IV). A continuação vive em
[`PIM_IV/pratica`](https://github.com/MayconDIS/PIM_IV/tree/main/pratica).

As atas de reunião e os planos de fase em `.planning/` das três frentes são
registros datados das sprints e foram mantidos na íntegra, sem reescrita, por serem
documentos históricos. Os links `file:///` que eles contêm apontam para os caminhos locais
da época.

## 📄 Licença

Distribuído sob a licença do arquivo [LICENSE](LICENSE).
