﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace App1S7AR.Models
{
    public class Estudiante
    {
        [PrimaryKey, AutoIncrement]
        public int Id { set; get; }
        [MaxLength(50)]

        public string Nombre { set; get;}
        [MaxLength(25)]

        public string Usuario { set; get; }
        [MaxLength(25)]

        public string Contrasenia { set; get; }

      
    
    }
}