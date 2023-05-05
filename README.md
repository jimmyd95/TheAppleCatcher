# TheAppleCatcher
 An AR version of the apple catcher game where users can catch falling objects from the sky via a bucket
 

https://user-images.githubusercontent.com/16414366/236370210-102bf87e-2dbc-4147-bcee-f526613a5a26.mp4
 

**Core features:** 

These are the features that your prototype really needs to function or to prove your point.

- Build a passthrough environment with “apples” falling from the sky. In my case, it's falling shiba dog
- Have buckets (virtual/augmented) catching them apples (put the controller inside the basket and track the controller. Don’t use hand tracking just now) Unfortuantely as with the current version, the bucket is just a virtual cube. I will implement this further after a few more iterations

There were various plug-ins I used, AR plug-in was one of them, but it was not applicable for this. The one that I used mainly was OpenXR and Oculus XR plug-in (Oculus Intergration). It allowed me to set the physical menu and smooth hand tracking. A good startup for people who wants to try out my set is: Valem Tutorials - https://www.youtube.com/watch?v=RtoTGYBdGI4. For those who wanted to try out other devices other than Oculus, you can look into the Quest & Hololens setup fropm https://localjoost.github.io/Passthrough-transparency-with-MRTK2-and-3-on-Quest-2Pro/. Very detailed walkthrough for other devices (I believe they are interchangable).

The Unity version was 2021.3.24f1, it worked, but with some bugginess. I also tried out 2022.2.17f1, which is slightly better. I'd recommend using that.
