using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 88. Merge Sorted Array
 * Teniendo dos Arrays de numeros enteros como entrada, y dos numeros enteros que representan los tamanos de cada
 * array, fusionar los arrays en uno solo, tomando en cuenta que ambos arrays estan ordenados de forma asencentes, y
 * que debe mantenerse ordenada, tambien la funcion no debe retornar nada, los cambios se hacen in-place sobre el primer array
 * input: int[] nums1, int m, int[] nums2, int n
 * output: la respuesta debe estar en el array nums1
 * 
 * restriccion clave: no se retorna un array nuevo la respusta es in-place en el array nums1
 * 
 * Fase 2: solucion inicial (fuerza bruta)
 *  Solucion  obvia: Podria  usar un loop while para agregar los datos de nums2 en el array nums1 y para despues utilizar
 *  un algoritmo de ordenamineto para volver a ordenar el array nums1
 *  
 *  Complejidad Temporal: al utilizar un loop para fusionar los arrays hasta ese punto seria O(N) pero podria se mas
 *   dependiendo del algoritmo de ordenamiento utilizado.
 *   
 *  Fase 3: Optimizacion y patrones algoritmicos\
 *      - Identificar el cuello de botella: El problema principal es mantener los numeros ordenados despues de fusionar
 *      los arrays.
 *      -Patron Aplicado: Two Pointers. Usare dos indices para recorrer los dos arrays a mismo tiempo y un tercero para saber 
 *      la posicion final de cada elemento.
 *      
 *      Pseudocodigo de la solucion optima:
 *      1. Inicializar los punteros, k (posicion en el array completo) es igual a (m + n) - 1, i (puntero para recorrer el array nums1) es igual 
 *      m - 1, j (posicion en el array nums2) igual a n - 1.
 *      2. Logica del loop: 
 *          a: el loop terminara cuando alguno de los punteros i o j sea menor a 0.
 *          b: Comparaciones:  nums1[i] > nums2[j] entonces:
 *              - nums1[i] es mayor se coloca en la posicion k dentro de nums1 y decrementamos i y k
 *              - nums2[j] es mayor se coloca en la posicion k dentro de nums1 y decrementamos j y k
 *      3. Al terminar el ciclo todos los numeros que queden en nums2 seran mas menores a los que estan en nums1, y se colocaran a inicio de nums1    
 *      
 *      
 */
namespace _01_Algoritmos_Y_Estructuras.LeetCode
{
    public class MergeSortedArray
    { 
        public void Solution(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = (m + n) - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }
            while(j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}
