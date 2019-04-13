using System;
namespace Core.Math.Numerics.Core.Math.Numerics
{
    /// <summary>
    /// <a href="https://en.wikipedia.org/wiki/Fast_inverse_square_root"></a>
    /// <a href="https://en.wikipedia.org/wiki/Methods_of_computing_square_roots#Approximations_that_depend_on_the_floating_point_representation">
    /// <a href="https://stackoverflow.com/questions/1349542/john-carmacks-unusual-fast-inverse-square-root-quake-iii">
    /// </summary>
    public class FastInverseSquareRoot
    {
        /// <summary>
        /// Original Quake III Arena C code ported to C#
        /// TODO: unit tests + benchmark tests
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static float Estimate( float number )
        {
	        long i;
	        float x2, y;
	        const float threehalfs = 1.5F;

	        x2 = number * 0.5F;
	        y  = number;
            i  = (long)y
                 // c code: * ( long * ) &y;          // evil floating point bit level hacking
                 ;
	        i  = 0x5f3759df - ( (long) y >> 1 );     // what the fuck? 
	        y  =
                    (float) i
                    // c code: * ( float * ) &i
                ;

            y  = y * ( threehalfs - ( x2 * y * y ) );   // 1st iteration
            //	y  = y * ( threehalfs - ( x2 * y * y ) );   // 2nd iteration, this can be removed

	        return y;
        }
    }
}
