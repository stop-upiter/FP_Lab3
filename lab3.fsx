// Functional Programming: Lab 3
// Student: Rizoeva Amina, 197

// Task 1
type HeaderType = |h1=1|h2=2|h3=3

type Content =   
    | Header of string*HeaderType   
    | Text of string*bool*bool
    | BulletItemsList of Content list
    | Paragraphs of Content list

type FormattedText =
    | Body of Content list

// Task 2
// HTML

// short fun: string list to string
let rdc (l: string list) = List.fold (fun acc elem -> acc + elem) "" l 

// bold tags
let b (s: string, cond: Boolean) = 
    if cond then "<b>" + s + "</b>"
    else s

// italic tags
let it (s: string, cond: Boolean) = 
    if cond then "<i>" + s + "</i>"
    else s

let format (x : FormattedText) = ...


// Task 3
let parse (x : string seq) : FormattedText = ...

// Task 4
let formatText : (FormattedText -> string) = ...

let strip : string -> string = parse >> formatText

// Task 5
let analyze (x : string seq) = ...
