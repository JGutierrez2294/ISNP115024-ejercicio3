Imports System

Module Program
    Sub Main(args As String())

        Dim numero As Int16
            Dim suma As Int32 = 0

            ' Bucle que contin�a hasta que el usuario ingrese un n�mero negativo o cero
            Do
            Console.Write("Introduce un n�mero positivo (un n�mero negativo o 0 para completar): ")
            numero = Convert.ToInt16(Console.ReadLine())

                ' Solo suma si el n�mero es positivo
                If numero > 0 Then
                    suma += numero
                End If

                ' El bucle se rompe si el n�mero es negativo o 0
            Loop While numero > 0

            ' Muestra la suma total
            Console.WriteLine("La suma de todos los n�meros positivos es: " & suma)
            Console.ReadKey() ' Pausa antes de cerrar el programa
        End Sub
End Module