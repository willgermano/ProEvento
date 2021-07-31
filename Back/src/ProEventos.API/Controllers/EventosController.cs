using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Domain;
using ProEventos.Persistence;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly ProEventosContext _context;
        public EventosController(ProEventosContext context)
        {
            _context = context;
        }
        
        // public IEnumerable<Evento> _evento = new Evento[]{
        //        new Evento(){
        //             Id = 1,
        //             DataEvento = "28/07/2021 19:00",
        //             ImagemURL = "foto1.jpg",
        //             Local = "São Paulo",
        //             Lote = "1",
        //             QtdPessoas = 2000,
        //             Tema = "Angular 11"
        //         },
        //         new Evento(){
        //             Id = 2,
        //             DataEvento = "29/07/2021 19:00",
        //             ImagemURL = "foto2.jpg",
        //             Local = "Minas Gerais",
        //             Lote = "2",
        //             QtdPessoas = 1500,
        //             Tema = ".NET 5 Core"
        //         },
        //         new Evento(){
        //             Id = 3,
        //             DataEvento = "30/07/2021 19:00",
        //             ImagemURL = "foto3.jpg",
        //             Local = "Bahia",
        //             Lote = "3",
        //             QtdPessoas = 1000,
        //             Tema = "Angular 11 e .NET 5"
        //         },
        //    };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            //return _evento.Where(x => x.EventoId == id);
            return _context.Eventos.FirstOrDefault(e => e.Id == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put: {id}";
        }
    }
}
