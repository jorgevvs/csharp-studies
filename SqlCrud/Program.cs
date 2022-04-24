using System;

namespace SqlCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Proprietario proprietario = new Proprietario()
            {
                Nome = "Thales",
                Telefone = "83982131251"
            };
            
            Proprietario proprietario2 = new Proprietario()
            {
                Nome = "Mariana",
                Telefone = "9280124412"
            };
            Proprietario proprietario3 = new Proprietario()
            {
                Nome = "Silvia",
                Telefone = "4421125612"
            };

            Carro carro = new Carro()
            {
                Modelo = "Fusca",
                Ano = 1978,
                Proprietario = proprietario
            };

            Carro carro2 = new Carro()
            {
                Modelo = "Gol",
                Ano = 2008,
                Proprietario = proprietario2
            };
            
            Carro carro3 = new Carro()
            {
                Modelo = "Etios",
                Ano = 2022,
                Proprietario = proprietario3
            };

            
            CarroRepositorio carroRepositorio = new CarroRepositorio();
            ProprietarioRepositorio proprietarioRepositorio = new ProprietarioRepositorio();

            Console.WriteLine(carroRepositorio.GetCarroById(4));
           
        }

    }
}
