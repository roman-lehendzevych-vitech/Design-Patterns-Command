# Design Patterns: Command

### 1. Quick idea about this pattern/Problem which this pattern solve?
Command is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.

This pattern solve problem such as: When you need to queue operations or schedule their execution
### 2. Where should we use this pattern (examples)?
Use the Command pattern when you want to parametrize objects with operations.
### 3. Pros and Cons
Pros:
- You can decouple classes that invoke operations from classes that perform these operations.
- You can introduce new commands into the app without breaking existing client code.
- You can implement undo/redo.
- You can implement deferred execution of operations.
- You can assemble a set of simple commands into a complex one.

Cons:
- The code may become more complicated since you’re introducing a whole new layer between senders and receivers.
