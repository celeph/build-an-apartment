# Course Project 2 - Build an Apartment

## Introduction

This project is part of [Udacity](https://www.udacity.com "Udacity - Be in demand")'s [VR Developer Nanodegree](https://www.udacity.com/course/vr-developer-nanodegree--nd017).

Given an empty apartment as a starter project, the goals of this assignment included

1) adding at least 15 models to the apartment,
2) adding Google Cardboard functionality to the scene,
3) adding lights,
4) creating an animated globe.

I grouped all models and components into following categories:

- **Office** with desk, desk chair, computers, mouse, keyboard, book shelf, books, a poster on the wall
- **Entrance** with a small rug
- **VR Stage** with rug, book shelf, computer, Oculus Rift model
- **Dining area** with refrigerator, table, chairs, fruit bowl
- **Living Room** with couch, armchairs, rug, coffee table, video projector, sleeping cat model, a poster on the wall
- **GvrEdiutorEmulator/Camera** and a background audio sample
- **Lights**
- **Animated Globe**

Taking inspiration from my real-life home I added a video projector on the living room table that plays an excerpt from the 1902 classic 'A Trip to the Moon' on the wall. 

To experiment with third-party models I added a sleeping cat to the sofa and a model of the Oculus Rift to the VR play zone, both are also inspired by real life. 

To make the scene appear a little more lived-in I added some poster frames with a picture of my cat and one of my rides on Zwift.

More wishful thinking and less representative of real life is the Skybox set to a mossy forest scene instead of the CitySkybox. To complete the environment I also added nature sounds in the background.

I'm submitting this project for Android. Tested successfully on Google Pixel 2 XL with Android 8.1.0.

## Reflections
 
I'm not sure how long exactly it took me to complete this project. During the week I spent about 3-4 hours, on the weekends about 16 hours - probably a total of about 20 hours between April 1st and April 8th. 

I spend a good amount of time trying to make the film projection work. This was not part of the assignment, but I had so much fun with it -- I really wanted to make it work before I submitted the assignment. There are probably better ways to accomplish the same or better effects, but I'm happy with the result. 

I converted the video clip into single frame images, reduced the number of images to a few selected scenes, added all frames to a folder 'Resources' and added a script (PlayMovie) that loads all frames from the folder into an array and updates the panel's texture in a given time interval. This allowed me to make the video work without using an actual video file (which, as far as I understand, is not supported on Android devices).

The solution was relatively simple, but it was challenging to realize I had to name the folder 'Resources' to make it work. When I tried a sub-directory within 'UdacityVR', the script just couldn't find any frames. And dragging & dropping each single frame into Unity would have taken even longer.

Lights are still a bit challenging, too. I think the scene turned out well, but I don't feel I have an intuition for ranges, intensities, lightmapping and other settings yet.

I loved about this project how easy it was to create a scene and view it in Cardboard. I'm amazed being able to look around as if it was a real apartment. I always expected this to be much more difficult. There are so many features and settings I don't know anything about yet, but it's incredible how quickly one can get up and running with Unity.

## Versions and Third Party Assets

- VR Scenes & Objects Starter Project v4.1.0

- [Unity 2017.2.0f3 (64-bit Windows)](https://unity3d.com/get-unity/download?thank-you=update&download_nid=48367&os=Win) 

- [GVR Unity SDK v1.70.0](https://github.com/googlevr/gvr-unity-sdk/releases/tag/1.70.0)

- [ffmpeg](https://www.ffmpeg.org/download.html) version N-90627-ge54679b6c1 (used to create frame images)

- [Audacity v2.0.3](https://sourceforge.net/projects/audacity/) (used to edit background sound sample)

- Oculus Rift Model by Eternal Realm, free download from [sketchfab.com](https://sketchfab.com/models/bac8bbee5cf743aeb09087656e7d6796#download), Creative Commons [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/)

- Sleeping Cat Scanned Model by samhodge, free download from [sketchfab.com](https://sketchfab.com/models/a603681aeea541d9a7dd0b87da6526a0#download), Creative Commons [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/)

- Scenes from ['A Trip to the Moon'](https://en.wikipedia.org/wiki/A_Trip_to_the_Moon) (Le voyage Dans la lune, 1902) by Georges Méliès, [Video Public Domain](https://en.wikipedia.org/wiki/File:Le_Voyage_dans_la_Lune_(Georges_M%C3%A9li%C3%A8s,_1902).ogv)

- Mossy Forest HDRI, free download from [hdrihaven.com](https://hdrihaven.com/hdri/?c=nature&h=mossy_forest), Creative Commons [CC0](https://hdrihaven.com/p/license.php)

- Forest Soundscape by [klankbeeld](http://www.freesound.org/people/klankbeeld/), free download from [freesound.org](https://freesound.org/people/klankbeeld/sounds/178374/), Creative Commons [CC BY 3.0](https://creativecommons.org/licenses/by/3.0/)



