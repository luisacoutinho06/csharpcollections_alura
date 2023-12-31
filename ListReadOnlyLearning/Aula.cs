﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListReadOnlyLearning
{
    // Classe aula que é mantida em um arquivo diferente:
    class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.Titulo = titulo;
            this.Tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public int CompareTo(object? obj)
        {
            Aula that = obj as Aula;
            return this.titulo.CompareTo(titulo);
        }
        public override string ToString()
        {
            return $"[Título: {titulo}, tempo: {tempo} minutos]";
        }
    }
}
