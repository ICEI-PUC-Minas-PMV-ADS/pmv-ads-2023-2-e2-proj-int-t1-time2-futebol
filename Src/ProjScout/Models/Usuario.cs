﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjScout.Models
{
    [Table("Usuários")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o nome !")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha !")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o perfil do usuário !")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Administrador, 
        Usuário
    }
}
