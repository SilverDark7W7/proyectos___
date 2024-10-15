<?php

		include("conexion.php");


 		$id = $_POST['id'];
 		$nombre = $_POST['nombre'];
 		$carrera = $_POST['carrera'];
 		$descripcion = $_POST['descripcion'];
		$imagen = $_FILES['imgF']['tmp_name'];




        $query = mysqli_query($conn, "SELECT id_candidatas FROM candidatas WHERE id_candidatas = $id");
        $nr = mysqli_num_rows($query);


		if($nr == 1){


			$consulta = "UPDATE candidatas SET nombre = '$nombre', Carrera='$carrera', descripcion='$descripcion' WHERE id_candidatas = $id";
			
			mysqli_query($conn,$consulta);

	

					echo "<script>s
					alert('SE MODIFICO');
					</script>";

		}else{

			echo "<script>
					alert('NO SE MODIFICO');
					</script>";
		
			
			}

			echo "<script>
			window.location = '../formulario/modificar_candidatas.php';
			</script>"


 		?>




