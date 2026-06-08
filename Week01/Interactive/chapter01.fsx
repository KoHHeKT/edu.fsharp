let add a b =
    let answer = a + b + "hello"
    answer

let explicit = ResizeArray<int>()
let typeHole = ResizeArray<_>()
let omitted = ResizeArray()

typeHole.Add 99
omitted.Add "text"

let combineElements<'T> (a:'T) (b:'T) (c:'T) =
    let output = ResizeArray<'T>()
    output.Add a
    output.Add b
    output.Add c
    output

combineElements 1 2 3
