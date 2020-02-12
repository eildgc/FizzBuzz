# FizzBuzz

Este programa imprime números del 1 al 100 pero cumpliendo ciertas condiciones.
Los números divisibles entre 3 se mostrarán como Fizz.
Los números divisibles entre 5 se mostrarán como Buzz.
Los que sean divisible entre 3 y 5 se mostrarán como FizzBuzz.
Los números que no entran en las condiciones planteadas, simplemente se imprimirá el número.

En este ejercicio se ve lo que es un LOOP o BUCLE.

Se utilizará un FOR, es un contador y este consiste en tres condiciones:

Primera condición: Inicialización. ¿Qué va a hacer antes de comenzar?
Segunda condición: ¿Qué tenemos que tener en cuenta antes de comenzar la iteracion del FOR
Tercera condición: ¿Qué se va a ejecutar después de cada iteración?

Esto en código se vería por el momento así:

for(int i = 0; i <=100; i++)

{

}

Pero hasta aquí no hemos terminado de escribir el programa.

Al correr por primera vez nuestro código nuestra inicialización (nuestra variable "i") empezará en 0,
mientras esta variable sea igual o menor a 100, "avanzará" sumándole 1 a nuestra variable "i" y se
repetirá el proceso hasta ser igual o menor a 100.   

Dentro de nuestro FOR se incluirán, en este caso, tres IF.

Estableceremos ciertas condiciones para indicar qué queremos hacer cuando en cada caso.

	1. Si el residuo de la división del número en que va nuestro contador entre 3 y 5 es igual a 0  5 nos
	imprimirá "FizzBuzz".
	Establecemos primero la revisión de esta operación de nuestro número actual entre 3 y 5
	primero debido a la manera en que se va ejecutando nuestro programa, pues pueden perderse números
	que sí cumplirían esta condición pero serían descartador de ir esta instrucción después de las
	condiciones 2 y 3.
	2. Si no, se revisa si el residuo de la división de nuestro número actual entre 3 es igual a 0,
	imprimirá "Fizz".
	3. Si no, se revisará si el residuo de la división de nuestro número actual entre 5 es igual a 0,
	se imprimirá "Buzz".
	4. Pero si nuestro  número actual no cumple en ninguna de las condiciones anteriores, simplemente se
	imprimirá el número actual.

Nuestro código debería ahora verse así.

for (int i = 0; i <= 100; i++)

{

	if (i % 3 == 0 && i % 5 == 0)

	{

		Console.WriteLine("FizzBuzz");

	}

	else if (i %3 == 0)

	{

		Console.WriteLine("Fizz");

	}

	else if (i %  5 == 0)

	{

		Console.WriteLine("Buzz");

	}

	else

	{

		Console.WriteLine(i);

	}


}

