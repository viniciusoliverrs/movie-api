using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_api.Models;

namespace movie_api.Data.Repositories.Mock
{
    static public class MovieData
    {
        static public List<Movie> Content = new List<Movie>{
            new Movie(234,"Vingadores Ultimato", "Após Thanos eliminar metade das criaturas vivas, os Vingadores precisam lidar com a dor da perda de amigos e seus entes queridos. Com Tony Stark (Robert Downey Jr.) vagando perdido no espaço sem água nem comida, Steve Rogers (Chris Evans) e Natasha Romanov (Scarlett Johansson) precisam liderar a resistência contra o titã louco.", "https://sujeitoprogramador.com/r-api/img/filme0.png"),
            new Movie(546,"Shazam!", "Billy Batson (Asher Angel) tem apenas 14 anos de idade, mas recebeu de um antigo mago o dom de se transformar num super-herói adulto chamado Shazam (Zachary Levi). Ao gritar a palavra SHAZAM!, o adolescente se transforma nessa sua poderosa versão adulta para se divertir e testar suas habilidades. Contudo, ele precisa aprender a controlar seus poderes para enfrentar o malvado Dr. Thaddeus Sivana (Mark Strong).", "https://sujeitoprogramador.com/r-api/img/filme1.png"),
            new Movie(125,"O Primeiro Homem","A vida do astronauta norte-americano Neil Armstrong (Ryan Gosling) e sua jornada para se tornar o primeiro homem a andar na Lua. Os sacrifícios e custos de Neil e toda uma nação durante uma das mais perigosas missões na história das viagens espaciais.","https://sujeitoprogramador.com/r-api/img/filme3.png"),
            new Movie(400,"Mission: Impossible – Fallout","Obrigado a unir forças com o agente especial da CIA August Walker (Henry Cavill) para mais uma missão impossível, Ethan Hunt (Tom Cruise) se vê novamente cara a cara com Solomon Lane (Sean Harris) e preso numa teia que envolve velhos conhecidos movidos por interesses misteriosos e contatos de moral duvidosa.","https://sujeitoprogramador.com/r-api/img/filme4.png"),
            new Movie(554,"The Meg","Na fossa mais profunda do Oceano Pacífico, a tripulação de um submarino fica presa dentro do local após ser atacada por uma criatura pré-histórica que se achava estar extinta, um tubarão de mais de 20 metros de comprimento, o Megalodon.","https://sujeitoprogramador.com/r-api/img/filme5.png"),
            new Movie(987,"Venom", "San Francisco, Estados Unidos. Eddie Brock (Tom Hardy) é um jornalista investigativo, que tem um quadro próprio em uma emissora local. Um dia, ele é escalado para entrevistar Carlton Drake (Riz Ahmed), o criador da Fundação Vida, que tem investido bastante em missões espaciais de forma a encontrar possíveis usos medicinais para a humanidade. ","https://sujeitoprogramador.com/r-api/img/filme6.png"),
            new Movie(700,"Pacific Rim: A Revolta","Filho de Stacker Pentecost (Idris Elba), responsável pelo comando do programa Jaeger, Jake (John Boyega) era um promissor talento do programa de defesa, mas abandonou o treinamento e entrou no mundo do crime ao vasculhar ferros-velhos em busca de peças de robôs abandonados.","https://sujeitoprogramador.com/r-api/img/filme7.png")
        };
    }
}