// Functional Programming: Lab 3
// Student: Rizoeva Amina, 197

// Task 1
type FormattedText =
  | Header of FormattedText   
  | BulletItemsList of FormattedText list 
  | Text of string
  | Bold of Boolean
  | Italic of Boolean  
  | Paragraphs of FormattedText list

// Task 2
let format (x : FormattedText) = ...


// Task 3
let parse (x : string seq) : FormattedText = ...

// Task 4
let formatText : (FormattedText -> string) = ...

let strip : string -> string = parse >> formatText

// Task 5
let analyze (x : string seq) = ...
