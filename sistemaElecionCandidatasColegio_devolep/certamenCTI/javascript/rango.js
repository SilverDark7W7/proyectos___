const rango1 = document.querySelector("#rango1");
const texto1 = document.querySelector("#la1");

const rango2 = document.querySelector("#rango2");
const texto2 = document.querySelector("#la2");

const rango3 = document.querySelector("#rango3");
const texto3 = document.querySelector("#la3");

const rango4 = document.querySelector("#rango4");
const texto4 = document.querySelector("#la4");

const rango5 = document.querySelector("#rango5");
const texto5 = document.querySelector("#la5");

rango1.onclick = () =>{
    texto1.innerHTML = rango1.value;
}

rango2.onclick = () =>{
    texto2.innerHTML = rango2.value;
}
rango3.onclick = () =>{
    texto3.innerHTML = rango3.value;
}
rango4.onclick = () =>{
    texto4.innerHTML = rango4.value;
}
rango5.onclick = () =>{
    texto5.innerHTML = rango5.value;
}
