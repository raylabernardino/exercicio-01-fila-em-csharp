using System;
using System.Collections.Generic;

class Cliente {
    public string Nome { get; set; }

    public Cliente(string nome)
    {
        Nome = nome;
    }
}

class Funcionario {
    public string Nome { get; set; }

    public Funcionario(string nome) {
        Nome = nome;
    }
}

class Program {
    static Queue<Cliente> filaAtendimento = new Queue<Cliente>();
    static List<Funcionario> funcionarios = new List<Funcionario>();

    static Random random = new Random();

    static void Main()
    {
        funcionarios.Add(new Funcionario("Funcionário 1"));
        funcionarios.Add(new Funcionario("Funcionário 2"));
        funcionarios.Add(new Funcionario("Funcionário 3"));

        for (int i = 1; i <= 10; i++)
        {
            var cliente = new Cliente($"Cliente {i}");
            filaAtendimento.Enqueue(cliente);
        }

        while (filaAtendimento.Count > 0)
        {
            var cliente = filaAtendimento.Dequeue();
            var funcionario = funcionarios[random.Next(funcionarios.Count)];

            int tempoAtendimento = random.Next(1, 11);

            Console.WriteLine($"{cliente.Nome} está sendo atendido por {funcionario.Nome}. Tempo de atendimento: {tempoAtendimento} minutos.");

            int tempoEspera = random.Next(1, 21);
            Console.WriteLine($"Tempo de espera de {cliente.Nome}: {tempoEspera} minutos");
        }

        Console.WriteLine("Todos os clientes foram atendidos.");
    }
}
