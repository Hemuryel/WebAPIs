﻿using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class UpdateCinemaDto
    {
      public string Nome { get; set; }
      public Endereco Endereco { get; set; }
      public int EnderecoId { get; set; }
    }
}
