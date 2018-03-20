# DSAL2-KFS
>By Kristian Flejsborg Sørensen (cph-kf96)

## The TreeNode
since the project was a binary tree I decided to make a structure using objects class in C# it looks like this.   
![](https://i.gyazo.com/942ca3e2cd4294d35ae291b013099d25.png)   
this does merge the branch and the leaf but I didn't see a reason to have two seperate classes, the TreeNode can contain a question, a answer, and two additional nodes that points to either left or right. This way I could make the 4 questions and end on the 5th with a answer to readout specifically from that path.   
The two additional TreeNode's allowed for easier navigation of the structure aswell.

## Navigation
I'll avoid showing the creation of the tree as it was a hardcoded mess, but the navigation is much smoother.   
![](https://i.gyazo.com/0316b263c488b73cb9ee6d4ff92cc2e1.png)   
NavigateTree takes in a existing TreeNode and a outside answer to the nodes current state, if the answer it yes the left tree is returned and if no the other. The reason for this is shown in the following picture, the `MakeTree()` just creates a full tree as `StudentActivity();` this is both the creation and logic function, the 4 boolean answers are given with the call of the function, and the program calls the `NavigateTree();` function to essentially overwrite the higher level tree with the new sub level tree, effectively navigating down the layers until the 5th layer is reached and then the answer is returned.   
![](https://i.gyazo.com/8256d59afddc5f2388e3ef30e0595c0f.png)   

## Test
for the record the order of the questions are as follows:
1. Attended lectures
2. Read textbook
3. Make exercises
4. Hand ins made in time
with this I ran the following test showen in the picture.   
![](https://i.gyazo.com/ec5b1ec7e68320eea2bc1e10186badc7.png)   
and the result of running to program is as follows.   
![](https://i.gyazo.com/16e6d85ae6e21da5240862a958e78a02.png)   
first one is correct as the student have done all the things.   
the second one is a failure since he havn't attended lectures, although he read the textbook and hands in on time, he havn't made the exercises.   
third is also a failure as it's similair to the second but this time he havn't read the textbook.   
fouth is a pass, although he failed to make hte exercises and read the textbook he still attended the lectures and handed in on time.   
fifth is a failure because of hand ins not made on time.   
likewise is sixth.   
seventh is a pass as it's only the textbook that have been forsaken.   

if you wise to read the code go to https://github.com/Retroperspect/DSAL2-KFS
