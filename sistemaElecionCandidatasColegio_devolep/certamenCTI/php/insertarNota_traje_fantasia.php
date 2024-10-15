<?php
    include("conexion.php");

    $id = $_POST['id']-1;
    $punteo1 = $_POST['rango1'];
    $punteo2 = $_POST['rango2'];
    $punteo3 = $_POST['rango3'];
    $punteo4 = $_POST['rango4'];

    $promedio = $punteo1+$punteo2+$punteo3+$punteo4;
    $promedio = $promedio / 4;

    echo $punteo1;

    $query = mysqli_query($conn, "SELECT * FROM traje_fantasia WHERE id_candidatas = $id");
    $nr = mysqli_num_rows($query);


if ($nr == 1){

/*CONSULTA KEVIN*/

$update = ("UPDATE traje_fantasia SET 
proyeccion ='$punteo1' + (SELECT SUM(proyeccion) FROM traje_fantasia where id_taje_fantasia = $id),

carisma ='$punteo2'+(SELECT SUM(carisma) FROM traje_fantasia where id_taje_fantasia = $id),

expresion_facial ='$punteo3'+(SELECT SUM(expresion_facial) FROM traje_fantasia where id_taje_fantasia = $id),

presentacion_traje='$punteo4'+ (SELECT SUM(presentacion_traje) FROM traje_fantasia where id_taje_fantasia = $id),


promedio='$promedio' + (SELECT SUM(promedio) FROM traje_fantasia where id_taje_fantasia = $id)

WHERE id_taje_fantasia = $id");




    mysqli_query($conn,$update);

}else{

$ingreso =  ("INSERT INTO traje_fantasia(id_candidatas,proyeccion, carisma, expresion_facial, presentacion_traje,promedio)
VALUES('$id','$punteo1','$punteo2','$punteo3','$punteo4','$promedio')");


mysqli_query($conn,$ingreso);

}
$promedio = ("UPDATE reporte SET
promedio_C1 ='$promedio'+(SELECT SUM(promedio_C1) FROM reporte where id_candidatas = $id)
WHERE id_candidatas = $id");

mysqli_query($conn,$promedio);



?>