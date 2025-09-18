using ProjectCommon;
using System;
// Curso com várias pessoas
var curso = new Curso("Programação em C#", "Aprenda C# do básico ao avançado");

curso.AdicionarAluno(new Pessoa("Ana", "Silva", 25));
curso.AdicionarAluno(new Pessoa("Bruno", "Souza", 30));
curso.AdicionarAluno(new Pessoa("Carla", "Pereira", 22));
curso.AdicionarAluno(new Pessoa("Daniel", "Costa", 28));
curso.AdicionarAluno(new Pessoa("Eduardo", "Lima", 27));
curso.AdicionarAluno(new Pessoa("Fernanda", "Alves", 24));
curso.AdicionarAluno(new Pessoa("Gabriel", "Martins", 29));
curso.AdicionarAluno(new Pessoa("Helena", "Rocha", 23));
curso.AdicionarAluno(new Pessoa("Igor", "Fernandes", 26));
curso.AdicionarAluno(new Pessoa("Juliana", "Ribeiro", 31));
curso.AdicionarAluno(new Pessoa("Kleber", "Duarte", 32));
curso.AdicionarAluno(new Pessoa("Larissa", "Melo", 21));
curso.AdicionarAluno(new Pessoa("Marcos", "Teixeira", 28));
curso.AdicionarAluno(new Pessoa("Natália", "Barros", 25));
curso.AdicionarAluno(new Pessoa("Otávio", "Cardoso", 27));
curso.AdicionarAluno(new Pessoa("Paula", "Freitas", 22));
curso.AdicionarAluno(new Pessoa("Rafael", "Moreira", 30));
curso.AdicionarAluno(new Pessoa("Sabrina", "Castro", 24));
curso.AdicionarAluno(new Pessoa("Thiago", "Pires", 29));
curso.AdicionarAluno(new Pessoa("Vanessa", "Oliveira", 23));

curso.ListarAlunos();
