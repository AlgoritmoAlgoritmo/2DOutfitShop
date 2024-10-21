ABOUT THIS
----------

This a PC game prototype made for a job test using Unity 2022.3.25f and C#.
I made everything except the characters, background and animation assets, which
were downloaded from Unity's asset store.


These were the requirements:
- A 2D navigable environment
- A shopkeeper NPC and a functional shop
- Items that not only the player could equip, but also that it was reflected
in the character if it was equipped or not
- Multiple interactable elements in the environment


This is what I achieved in 72 hours:
- A 2D navigable environment using InputSystem, plus movement animations for
the main character.
- The shopkeeper NPC with and the fully functional which implied: a wallet
system, an inventory/item system. To access the shop I used a collider to
detect when the player was close enough to display the shop UI.
- An equipment system that reflected the changes in the main character.


What I left out:
- Multiple interactable elements in the environment.

The reason why I didn't achieve this is that I chose to focus on making the
shop and equipment systems as bugless as possible over adding more content.
