module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.

let counter = 0
let rec collatz n =
  let counter = counter + 1
  if n = 1 then counter
  elif n % 2 = 0 then collatz (n / 2)
  else collatz (n * 3 + 1)
