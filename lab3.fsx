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

// short tagging
let t (s: string) (tag: string) = "<" + tag + ">" + s + "</" + tag + ">"

// bold tags
let bold (cond: bool) (s: string) = 
    if cond then t s "b"
    else s

// italic tags
let italic (cond: bool, s: string) = 
    if cond then t s "i"
    else s

// get formatted text
let text (label: string, isBold: bool, isItalic: bool) = 
    italic isItalic (bold isBold label)
    
// header type number i tags
let header (label: string, headType: HeaderType) = t label ("h"+ (string headType))

// bullet item tags
let bullet_items (bl: Content list)(d: int) f = 
    if bl.IsEmpty then ""
    else t (rdc (List.map (fun item -> t (f item (d+1)) "li") bl)) "ul"
    
// paragraph tags
let paragraph (p: Content list)(d: int) f = 
    if p.IsEmpty then ""
    else rdc (List.map (fun item -> t (f item (d+1))"p") p)
    
let rec content_tagger (deep: int) (x: Content) = function
    | Header (h, ht) -> header (h, ht)
    | Text (l,b,i)-> text (l,b,i)
    | BulletItemsList bl -> bullet_items bl deep content_tagger
    | Paragraphs p -> paragraph p deep content_tagger


let format (x : FormattedText) = ...


// Task 3
let parse (x : string seq) : FormattedText = ...

// Task 4
let formatText : (FormattedText -> string) = ...

let strip : string -> string = parse >> formatText

// Task 5
let analyze (x : string seq) = ...
