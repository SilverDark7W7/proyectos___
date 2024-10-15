var a = 0;
var b = 0;


function idca(){

       b++;

        var cad=document.getElementById('id').value = ++a;
        var foto=document.getElementById("foto");
        
        foto.src="../img/candidatas/"+b+".jpg";
        
        

if(a == 13){
  
    red();
}

}

function red(){
var C = document.getElementById('C').innerText;
switch(C){

case 'Traje Fantasia':
location.href="portada_coreografia.html";
break;

case 'Traje de Deportes':
location.href="portada_vestuario_casual.html";
break;

case 'Vestuario Casual':
location.href="portada_traje_noche.html"
break;

case 'Traje de Noche':
  
location.href="portada_pregunta_final.html";
break;

case 'Pregunta Secreta':
location.href="portada_pregunta_final.html";
break;

case 'Pregunta Final':
location.href="portada_pregunta_final.html";
break;
  }
}




function demo(){
  console.log('Esperando');
  setTimeout(limpiar(),2000); 
}


function limpiar(){

const rango1 = document.querySelector("#rango1").value = 0;
const texto1 = document.querySelector("#la1").innerHTML = 0;

const rango2 = document.querySelector("#rango2").value = 0;
const texto2 = document.querySelector("#la2").innerHTML = 0;

const rango3 = document.querySelector("#rango3").value = 0;
const texto3 = document.querySelector("#la3").innerHTML = 0;

const rango4 = document.querySelector("#rango4").value = 0;
const texto4 = document.querySelector("#la4").innerHTML = 0;

const rango5 = document.querySelector("#rango5").value = 0;
const texto5 = document.querySelector("#la5").innerHTML = 0;

console.log('SE RESETEO');

}




