﻿using SQLite;


namespace Agenda.Classes
{
    public class Pessoas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email {  get; set; }
        public string Telefone {  get; set; }
        public string Anotacoes {  get; set; }

    }
}
