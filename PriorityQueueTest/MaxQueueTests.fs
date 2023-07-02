module PriorityQueueTest.MaxQueue

open NUnit.Framework
open PriorityQueue.MaxQueue
open Microsoft.FSharp.Collections

let elements = [ 4; 10 ]
let maxElement = Seq.fold max elements[0] elements

[<Test>]
let MaxQueue_Extracts_MaxPriorityElement () =
    let state = insert elements
    let extracted, left = extract state

    Assert.AreEqual(maxElement, extracted)
    Assert.AreEqual(Seq.except [maxElement] elements, left)
