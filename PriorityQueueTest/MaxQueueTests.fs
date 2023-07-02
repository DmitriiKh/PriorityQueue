module PriorityQueueTest.MaxQueue

open NUnit.Framework
open PriorityQueue.MaxQueue
open Microsoft.FSharp.Collections

let elements = [ 4; 10 ]
let maxElement = Seq.fold max elements[0] elements

[<Test>]
let MaxQueue_Extracts_MaxPriorityElement () =
    let queue = insert elements
    let extracted = extract queue

    Assert.AreEqual(maxElement, extracted)
