namespace PronosticoTiempo.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PronosticoTiempo.Controllers.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class EmotionsController : ControllerBase
    {
        [HttpGet]
        [Route("ConNumero")]
        public string Emocion(int suerte)
        {
            if(suerte == 0)
            {
                return "Sos una persona indiferente";
            }
            if(suerte == 1) {
                return "Sos una persona feliz";
            }
            if (suerte == 3)
            {
                return "Sos una persona aburrida";
            }
            else
                return "Estoy muy ocupado, no puedo atenderte en este instante";
        }
        [HttpPost]
        [Route("ConNumero")]
        public string Emocion_2([FromBody] int suerte)
        {
            if (suerte == 0)
            {
                return "Sos una persona indiferente";
            }
            if (suerte == 1)
            {
                return "Sos una persona feliz";
            }
            if (suerte == 3)
            {
                return "Sos una persona aburrida";
            }
            else
                return "Estoy muy ocupado, no puedo atenderte en este instante";
        }
        [HttpPost]
        [Route("ConModelo")]
        
        public string Emocion_3([FromBody] Luck luck)
        {
            if (luck.luckID == 0)
            {
                return "Sos una persona indiferente";
            }
            if (luck.luckID == 1)
            {
                return "Sos una persona feliz";
            }
            if (luck.luckID == 3)
            {
                return "Sos una persona aburrida";
            }
            return "Estoy muy ocupado, no puedo atenderte en este instante";
        }
    }
}
