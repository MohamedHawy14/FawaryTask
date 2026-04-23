Fawry Internship Task - Quantum Car
Task solution for designing a flexible Car Engine system.

Implementation Details:
Dependency Injection: The Car depends on the IEngine interface, not concrete classes. This allows swapping engines at runtime via ReplaceEngine().

Factory Pattern: Used CarFactory to encapsulate the creation logic.

Hybrid Logic: MixedHybridEngine handles the transition between Electric and Gas based on the 50 km/h threshold internally.

Speed Handling: Acceleration/Braking is done in 20 km/h steps, but each step notifies the engine unit 1-by-1 to satisfy the requirement of advising the engine.

Project Structure:
IEngine.cs: The core interface.

BaseEngine.cs: To avoid code repetition between different engine types.

Car.cs: Main logic for movement and engine management.

CarFactory.cs: For object creation.

Program.cs: Test scenarios and demo.

Decisions:
Solved using C# because it's my primary stack and allows for cleaner implementation of the required patterns.

Kept the design simple as requested, avoiding over-engineering while maintaining SOLID principles.
