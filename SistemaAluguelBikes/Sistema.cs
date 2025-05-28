using System;
using System.Collections.Generic;
using ProjetoAluguelBicicletas.Models;

public class Sistema
{
    public Aluguel IniciarAluguel(Cliente cliente, List<Bicicleta> bicicletas, DateTime dataInicio)
    {
        var aluguel = new Aluguel();
        aluguel.RegistrarAluguel(cliente, bicicletas, dataInicio);
        return aluguel;
    }

    public void RegistrarDevolucao(Devolucao devolucao, Aluguel aluguel, DateTime dataDevolucao, decimal multa)
    {
        devolucao.RegistrarDevolucao(aluguel, dataDevolucao, multa);
    }

    public Recibo EmitirRecibo(Aluguel aluguel, Devolucao devolucao = null)
    {
        return Recibo.GerarRecibo(aluguel, devolucao);
    }
}
