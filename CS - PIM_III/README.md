# 📚 Plataforma de Educação Digital Segura

Projeto desenvolvido para o PIM (Projeto Integrado Multidisciplinar) do curso de Análise e Desenvolvimento de Sistemas.

## 🎯 Objetivo

Desenvolver uma plataforma de educação digital que promova a inclusão tecnológica, garantindo segurança da informação e proteção de dados dos usuários.

---

## 🧱 Estrutura do Projeto (Classes)

O sistema foi desenvolvido utilizando Programação Orientada a Objetos (POO), com as seguintes classes principais:

### 👤 Usuario
Classe base do sistema.

**Atributos:**
- nome
- email
- senha

**Métodos:**
- autenticar()
- atualizarDados()

---

### 🎓 Aluno (Herda de Usuario)

Representa o aluno na plataforma.

**Atributos:**
- simulado
- desempenho
- xp

**Métodos:**
- realizarSimulado()
- visualizarDesempenho()

---

### 📝 Simulado

Responsável pelos testes aplicados aos alunos.

**Atributos:**
- listaQuestoes
- pontuacao

**Métodos:**
- iniciarSimulado()
- finalizarSimulado()

---

### 📊 Desempenho

Armazena os resultados do aluno.

**Atributos:**
- acertos
- erros
- porcentagem

**Métodos:**
- calcularResultado()

---

### ⭐ XP

Sistema de pontuação e progressão.

**Atributos:**
- pontos
- nivel

**Métodos:**
- adicionarXP()
- subirNivel()

---

## 🔗 Relacionamentos

- `Aluno` herda de `Usuario`
- `Aluno` possui um `Simulado`
- `Aluno` possui um `Desempenho`
- `Aluno` possui um sistema de `XP`

---

## 🛠️ Tecnologias Utilizadas

- C#
- .NET
- Programação Orientada a Objetos (POO)

---

## 📌 Conceitos Aplicados

- Abstração
- Encapsulamento
- Herança
- Polimorfismo

---

## 🔐 Segurança

O sistema considera boas práticas de segurança como:
- Proteção de dados do usuário
- Controle de acesso
- Estrutura preparada para LGPD

---

## 🚀 Possíveis Melhorias

- Implementação de banco de dados
- Interface gráfica (GUI)
- Sistema de login com criptografia
- Dashboard de desempenho

---

## 👨‍💻 Autor

Projeto desenvolvido por:
- Gabriel Alves
- Maciel
- Mycon Douglas
- Rafael Mesquita

---

## 📅 Data

2026