<div align="center">
  <h1>Nex_TI – EdTech Learning Platform</h1>
  <p><strong>Projeto Integrado Multidisciplinar (PIM III) — Análise e Desenvolvimento de Sistemas — UNIP</strong></p>

  <img src="https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white" alt="HTML5"/>
  <img src="https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white" alt="CSS3"/>
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#"/>
  <img src="https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="SQL Server"/>
  <img src="https://img.shields.io/badge/Figma-F24E1E?style=for-the-badge&logo=figma&logoColor=white" alt="Figma"/>
  <img src="https://img.shields.io/badge/UML-Astah_10.1-orange?style=for-the-badge" alt="Astah"/>
</div>

---

## 📂 Estrutura

Este é o repositório único do PIM III. As frentes do projeto, antes separadas em
repositórios distintos, vivem aqui como pastas de primeiro nível:

```text
📁 PIM_III/
├── 📁 teorica/     # Monografia ABNT interativa (HTML/CSS), protótipos, cronogramas e atas
├── 📁 uml/         # Modelagem UML (Astah), diagramas exportados e backlog do produto
├── 📁 .agents/     # Skills e instruções de agentes de IA, compartilhadas pelas frentes
├── 📁 .vscode/     # Configuração do editor para o workspace inteiro
└── 📄 .gitattributes, .gitignore, LICENSE
```

### Por frente

| Pasta | Conteúdo |
|---|---|
| [`teorica/`](teorica) | Relatório ABNT em HTML/CSS (`index.html`), `assets/`, `design_DNA/`, `docs/` (PDFs entregues) e `examples/` |
| [`uml/`](uml) | `01_Documentacao_Teorica/`, `02_Modelagem_UML/` (fonte `.asta` + PNGs), `03_Codigo_Gerado/` |

## 📖 Como abrir o relatório

Abra [`teorica/index.html`](teorica/index.html) no navegador, ou use a extensão Live Server
do VS Code (porta `5501`, já configurada em `.vscode/settings.json`).

## 💻 Parte prática

A implementação em código (frontend, API C# .NET e scripts SQL Server) começou no PIM III e
continuou no PIM IV. Ela vive em [`PIM_IV/pratica`](https://github.com/MayconDIS/PIM_IV/tree/main/pratica).

## 🧬 Histórico

Este repositório foi formado a partir de dois repositórios anteriores, com o histórico de
commits preservado via `git subtree`:

- `PIM_III-Parte_Teorica` → `teorica/`
- `PIM_III-Documentacao_UML` → `uml/`

As atas de reunião e os planos de fase em `teorica/.planning/` e `uml/.planning/` são
registros datados das sprints e foram mantidos na íntegra, sem reescrita, por serem
documentos históricos. Os links `file:///` que eles contêm apontam para os caminhos locais
da época.

## 📄 Licença

Distribuído sob a licença do arquivo [LICENSE](LICENSE).
