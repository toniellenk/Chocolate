﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Produto
/// </summary>
public class Produto
{
    public int IdProduto { get; set; }
    public string NomeProduto { get; set; }
    public double PrecoUnitario { get; set; }
    public int UnidadesEstoque { get; set; }
}