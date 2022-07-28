# Chain of Responsibility

Organization has hierarchy CEO <- Division Director <- Subdivision Manager <- Program Manager <- Project Manager.

Project Manager has the authorization to approve costs up to 500$, Program Manager up to 2'000$, Subdivision Manager up to 5'000$, Division Director up to 20'000$ and CEO up to 100'000$.

Choose your favorite OOP language and implement CLI application using _Chain of Responsibility_ pattern (https://refactoring.guru/design-patterns/chain-of-responsibility)

CLI must take in as an input expense request amount and print out who did approve the request.
