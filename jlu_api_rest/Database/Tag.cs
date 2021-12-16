﻿using System.ComponentModel.DataAnnotations;

namespace jlu_api_rest.Database;

public class Tag
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string ColorCLassCss { get; set; }
}