using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RpgMvc.Models;

namespace RpgMvc.Controllers
{
    public class DisputasController : Controller
    {
        public string uriBase = "http://localhost:5000/Disputas/";
        //xyz deve ser substituido pelo nome do site na API

    [HttpGet]
    public async Task<ActionResult> IndexAsync()
    {
        try
        {
            //criação da variável http e obtenção do token guardado na session
            HttpClient httpClient = new HttpClient();
            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            //definição da rota da API que busca a lista de personagens na API, retornando uma lista 
            //se o método tiver exito ou uma mensagem caso de erro
            string uriBuscaPersonagens = "http://localhost:5000/Personagens/GetAll"; //SUBSTITUIR SE NECESSÁRIO
            HttpResponseMessage response = await httpClient.GetAsync(uriBuscaPersonagens);
            string serialized = await response.Content.ReadAsStringAsync();


            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                List<PersonagemViewModel> listaPersonagens = await Task.Run(() =>
                    JsonConvert.DeserializeObject<List<PersonagemViewModel>>(serialized));

                //Se o status da requisição for 200, deserializamos para transformar numa lista de personagens
                // e depois são geradas duas ViewBags a partir da lista de personagens, 
                //uma como atacantes e outra como oponentes
                ViewBag.ListaAtacantes = listaPersonagens;
                ViewBag.ListaOponentes = listaPersonagens;
                return View();
            }
            else
                throw new System.Exception(serialized);

        }
        catch(System.Exception ex)
        {
            TempData["MensagemErro"] = ex.Message;
            return RedirectToAction("Index");
        }
    }

    [HttpPost]
    public async Task<ActionResult> IndexAsync(DisputaViewModel disputa)
    {
        try
        {
            HttpClient httpClient = new HttpClient();
                string uriComplementar = "Arma";

                var content = new StringContent(JsonConvert.SerializeObject(disputa));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar, content);
                string serialized = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    disputa = await Task.Run(() => JsonConvert.DeserializeObject<DisputaViewModel>(serialized));
                    TempData["Mensagem"] = disputa.Narracao;
                    return RedirectToAction("Index", "Personagens");
                }
                else
                    throw new System.Exception(serialized);
        }
        catch(System.Exception ex)
        {
            TempData["MensagemErro"] = ex.Message;
            return RedirectToAction("Index");
        }
    }
    
    [HttpGet]
    public async Task<ActionResult> IndexHabilidadesAsync()
    {
        try
        {
            HttpClient httpClient = new HttpClient();
            string token = HttpContext.Session.GetString("SessionTokenUsuario");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            string uriBuscaPersonagens = "http://localhost:5000/Personagens/GetAll";  //xyz --> Seu endereço de API             
            HttpResponseMessage response = await httpClient.GetAsync(uriBuscaPersonagens);
            string serialized = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                List<PersonagemViewModel> listaPersonagens = await Task.Run(() =>
                    JsonConvert.DeserializeObject<List<PersonagemViewModel>>(serialized));

                ViewBag.ListaAtacantes = listaPersonagens;
                ViewBag.ListaOponentes = listaPersonagens;
                //return View(); //Remova esta linha
            }
            else
                throw new System.Exception(serialized);

            string uriBuscaHabilidades = "http://localhost:5000/PersonagemHabilidades/GetHabilidades";//xyz --> Seu endereço da API
            
            
            response = await httpClient.GetAsync(uriBuscaHabilidades);
            serialized = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                List<HabilidadeViewModel> listaHabilidades = await Task.Run(() =>
                    JsonConvert.DeserializeObject<List<HabilidadeViewModel>>(serialized));
                ViewBag.ListaHabilidades = listaHabilidades;
            }
            else
                throw new System.Exception(serialized);

            return View("IndexHabilidades");
        }
        catch(System.Exception ex)
        {
            TempData["MensagemErro"] = ex.Message;
            return RedirectToAction("Index");
        }
    }






















    }
}