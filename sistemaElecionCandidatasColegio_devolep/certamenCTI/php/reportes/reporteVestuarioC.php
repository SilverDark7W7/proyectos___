<?php

			
		include ('plantillaVestuarioC.php');
		require '../conexion.php';



		$query = "SELECT candidatas.nombre, candidatas.Carrera, vestuario_casual.promedio From vestuario_casual INNER JOIN candidatas ON candidatas.id_candidatas=vestuario_casual.id_candidatas ORDER BY (promedio) DESC";

		$resultado = $conn->query($query);


		$pdf  = new PDF();
		
		$pdf-> AddPage();

		$pdf->SetFillColor(222,232,232);
		$pdf->SetFont('Arial','B',12);
		$pdf->Cell(60,6,'NOMBRE',1,0,'C',1);
		$pdf->Cell(60,6,'CARRERA',1,0,'C',1);
		$pdf->Cell(60,6,'PROMEDIO',1,1,'C',1);

		$pdf->SetFont('Arial','',10);

		$pdf->SetFillColor(255,255,255);
		$pdf->SetFont('Arial','B',12);
		$pdf->Cell(10,11,'#',1,0,'C',1);
		$pdf->Cell(100,11,'NOMBRE',1,0,'C',1);
		$pdf->Cell(60,11,'CARRERA',1,0,'C',1);
		$pdf->Cell(20,11,'NOTA',1,1,'C',1);

		$pdf->SetFont('Arial','',17);
		$cont= 1;

		while($row = $resultado->fetch_assoc())
		{   
			if($cont == 1){
			$pdf->SetFillColor(255, 255, 0);
			$pdf->SetFont('Arial','B',15);
			$pdf->Cell(10,11,$cont,1,0,'C',1);
			$pdf->Cell(100,11,$row['nombre'],1,0,'C',1);
			$pdf->Cell(60,11,$row['Carrera'],1,0,'C',1);
			$pdf->Cell(20,11,$row['promedio'],1,1,'C',1);
			}else{
            $pdf->SetFont('Arial','B',12);
			$pdf->SetFillColor(255,255,255);
			$pdf->Cell(10,9,$cont,1,0,'C',1);
			$pdf->Cell(100,9,$row['nombre'],1,0,'C',1);
			$pdf->Cell(60,9,$row['Carrera'],1,0,'C',1);
			$pdf->Cell(20,9,$row['promedio'],1,1,'C',1);
			}
			$cont++;
		}

		$pdf->Output();






?>