<?php




include("conexion.php");

    $punteo1 = $_POST['rango1'];
    $punteo2 = $_POST['rango2'];
    $punteo3 = $_POST['rango3'];
    $id = $_POST['id']-1;
    

    $promedio = $punteo1+$punteo2+$punteo3;
    $promedio = $promedio / 3;
    



    $query = mysqli_query($conn,"SELECT * FROM pregunta_final WHERE id_pregunta_final  = $id");
    $nr = mysqli_num_rows($query);





if ($nr == 1){



    $update = ("UPDATE pregunta_final SET 
    espontaneidad = $punteo1+
    (SELECT SUM(espontaneidad) from pregunta_final WHERE id_pregunta_final = $id),
    
    calidad_respuesta = $punteo2+
    (SELECT SUM(calidad_respuesta) from pregunta_final WHERE id_pregunta_final = $id),

    coherencia_respuesta = $punteo3+
    (SELECT SUM(coherencia_respuesta) from pregunta_final WHERE id_pregunta_final = $id),
    
    promedio = $promedio+(SELECT SUM(calidad_respuesta) from pregunta_final WHERE id_pregunta_final = $id)

    where id_pregunta_final = $id");




    mysqli_query($conn,$update);

}else{


$ingreso =  ("INSERT INTO pregunta_final
(espontaneidad,calidad_respuesta,coherencia_respuesta,promedio)
VALUES('$punteo1','$punteo2','$punteo3','$promedio') ");


mysqli_query($conn,$ingreso);

}




$promedio = ("UPDATE reporte_final SET 
promedio_f =(SELECT promedio_F FROM reporte WHERE id_candidatas = $id ORDER BY promedio_F DESC ),

subtotal=$promedio+(SELECT SUM(subtotal) FROM reporte_final where id_finalistas = $id)
WHERE id_finalistas =  $id");


$final = ("UPDATE reporte_final SET 
total = (SELECT (subtotal+promedio_f) /2
FROM reporte_final WHERE id_finalistas = $id) 
WHERE id_finalistas = $id");


mysqli_query($conn,$promedio);
mysqli_query($conn,$final);



?>