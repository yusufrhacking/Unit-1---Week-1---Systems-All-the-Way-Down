# Unit 1 - Systems All the Way Down

## Relevant Unity Manual Pages
https://docs.unity3d.com/Manual/UsingTheEditor.html

## Relevant Slides from Class
https://myuva-my.sharepoint.com/:p:/g/personal/jcb2h_virginia_edu/EQauVRZG8YZBh2MRnkA6F6gBAqCNDW8Z1ayc22WL6kWqtg?e=64gtvR

## Skills

* The Unity Editor + how a game is made
* The areas of the editor
* Scenes
* Organizing your scene
* Creating GameObjects
* Create Empty GameObject
* Parent / Child Relationships
* Assets
* Organizing Assets 
* Navigating a scene
	* Move vs Orbit vs Zoom
	* Focus Selected
	* The 3D Compass and 3D Space
	* Orthographic vs Perspective view
* Manipulating Objects
* Scene vs Game view
* Cameras
* Align Camera to View
* Using Components

## Level

1. Put water in the pool 
2. Put a rubber duck on the water
3. Make the water appear more water-y
4. Create a deck
5. Make the deck appear more deck-like
6. Move the pool onto the deck
	* Did your water and duck move with the pool?
7. Double check that all your objects in your Scene are organized!
8. Use the "ObjectRotator" script to make the duck swim around in the pool

## Bosses
### Bowser (if you are new to coding, completed the “level” and want a challenge)
<img src="https://user-images.githubusercontent.com/7291792/187090817-9c0523ad-2e40-4760-8f93-b92516b64b7f.png" width=200/>

Using spheres, the provided materials, and the “ObjectRotate” script provided, build a working solar system in the "OuterSpace" Scene provided that has all the planets orbiting the sun with different orbit times (relative to each other) as well as two orbiting moons on two different planets (your choice).

Make it so one planet is "Earth", has the grass material on its surface, and the pool with water and duck on the water surface.

### Hornet (if you know some coding and want a challenge)
<img src="https://user-images.githubusercontent.com/7291792/187090928-364593f1-da58-46bc-a4a5-e777fd46fdd2.png" width=200/>

Do the above, but have its speed controllable via a value you input via the inspector at Runtime (i.e. when it's playing). 
You will most likely need the following manual pages / scripting references:
* https://docs.unity3d.com/Manual/class-Transform.html
* https://docs.unity3d.com/ScriptReference/Transform.GetChild.html
* the [SerializeField] attribute, which can go before a field declaration in a script to expose that field to the Unity Editor Inspector (e.g. `[SerializeField] float myFloatValue` will show "My Float Value" as an editable field in the Inspector when that script is used as a Component on a GameObject)

### The Demon of Hatred (if you are familiar with Unity and coding and want a challenge)
<img src="https://user-images.githubusercontent.com/7291792/187091229-df150009-ed6c-4d7b-8640-3c79fa270cbd.png" width=200/>

Build the solar system above, but with the following features:
* You can check a boolean value and the planets will sort themselves from largest to smallest with smallest nearest to the sun
* You can uncheck the same boolean and they will return to their original configuration
* When in “largest to smallest” view, their orbits speeds change based on their proximity to the sun (and it also switches back when you uncheck the boolean)
* If you scale the planets between runtimes the above system takes that into account (i.e. you are not sorting their size / location by hand or using pre-determined object/position pairs)
