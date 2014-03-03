#load "Library1.fs"
open FSharpIn15Minutes


// Comments start with two forwardslashes.

// In F# parentheses are optional but tabs are required to determine code blocks
//
// Although type declarations are seldom needed, F# IS strongly typed.
// Type inference is just very good.

// Here's a new module
module basic = 
   
// Basic examples:

// let sets values (not to be confused with variables)
// Values are immutable by default
    let string1 = "this"
// String concatination works like many strongly-typed languages with a "+" operator
    let concatString = "Hello" + " " + "World"

// Math works as expected
    let addition = 1+1 // => 2
    let subtraction = 2-1 // => 1
    let multiplication = 1*2 // => 2
    let division = 2/1 // => 2

// Equality is =
    let integerValue = 5
    let notEqual = integerValue = 4 // => false
    let equal = integerValue = 5 // => true

// You need and, or, & not for logic, too
    let itsNotTrue = not true // => false
    let itsFalse = true && false // => false
    let itsTrue = true || false // => true

// Nesting order of operations works as expected
    let myint = 3*(1-2) // => -3

// Types
/////////////////////

module types =
// F# uses .NET's object types
    let integerType = 1
    integerType.GetType()
    let floatType = 1.
    floatType.GetType()
    let stringType = ""
    stringType.GetType()
    let booleanType = false
    booleanType.GetType()