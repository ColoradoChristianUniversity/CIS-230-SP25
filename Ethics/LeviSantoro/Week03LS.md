# Question:
While maintaining an extremely popular Open-Source project, authorities contact you asking that you introduce back door code to allow them to gather the needed evidence to stop an online child trafficking scheme. What are three responses? What do you do?
> Note: an open-source maintainer is a volunteer who owns a repository others contribute to. The repository, if popular, will be used in many software programs either as reference or as a library. A company does not own an open-source project.
# Dilemma Breakdown:
This dilemma is a classic example of the fight between the values of security and privacy.
- On one hand, it appears incredibly honorable that your open-source program will help enforce security by assisting in putting an end to a child trafficking scheme.
	- There is also a possibility that your program is directly helping these heinous actions, and you want to put a stop to it.
- However, opening a back door to the authorities enables immense risk to your program and the privacy of every user who utilizes your code.
	- In addition, if people find out that their data is being used without their permission, it could seriously hinder your reputation as a developer.
To answer this question, some assumptions will have to be made.
1. I am the owner of the repository - It specifies that I am maintaining the code and the note implies that maintaining the coed means I am the owner of the repository
	* This removes the "go to the higher authority" response
2. The authorities are legitimate - An investigation has proven that they are the real people with power.
	* This removes the "find out if they are real" response
3. They are legally allowed to perform this action - Many sources online (e.g., the Apple backdoor case) cannot agree whether this would be possible. Still, for this example, it is perfectly legal and justified for them to ask such a thing.
	* This removes the "Do you have a warrant?" response
# Response 1: Ask fellow developers for advice if they have encountered this issue before
### Reasoning:
The open-source community is filled with many different people who have diverse experiences. While maintaining a popular open-source repository, you will eventually connect with other developers willing to share their mistakes and tips, especially if someone has experienced this situation. Therefore, asking select developer community members about the situation or if they know anyone who can help will relieve stress.
### Pros:
- A developer with the same experience could end the dilemma immediately with previous legal experience.
- Allows for better responses to the dilemma at hand.
- Developers might be able to find tips for navigating implementation, security, or legal problems.
### Cons:
- It might not be an option.
	- There might be problems with the agreement not allowing you to disclose this operation.
- You might burden people with a dilemma they don't want to deal with or know about.
### Expected Dialogue:
- Me: "Hey folks, I'm in a pickle. Does anybody have experience with the government demanding tampering with your repository?"
- Developer 1: "Nope"
- Developer 2: "Uh… no? Did something happen?"
- Me: "Well, yeah. Do you know anyone who might have dealt with that stuff?"
- Developer 3: "I have an acquaintance who did. I worked with them on a project that got caught up with the government, long story. He's better to explain how we dealt with that, I could connect you with them."
- Me: "That would be much appreciated; I didn't know where to start. Thanks!"
### Verse: Proverbs 15:22
Without counsel plans fail, but with many advisers they succeed.
### First Principle: Community
- When facing such an extreme or new situation, having someone alongside you who has faced the same problem is motivating, especially since they are usually willing to help or give advice.
# Response 2: Implement the back door, but with many conditions and restrictions
### Reasoning:
Since the authorities have the legal right to perform this action, allowing them a backdoor to stop such a horrendous operation appears justified. However, every precaution and safeguard will be implemented when developing this code. For example:
- Developing terms and conditions about what (if any) data will be collected.
	- Attempting to minimize the total amount collected to only relevant evidence.
	- How collected data will be stored.
	- What to do after data is collected.
- Making sure security risks are kept to a minimum.
	- A backdoor itself is a security risk, so making every security precaution is a priority.
- You can attempt to diminish as much responsibility as you can with this development.
Considering the success of the repository, it's not unreasonable to assume you could hire a lawyer to assist in this, but very unlikely.
### Pros:
- Assisting in the apprehension of a child trafficking scheme.
- Knowledge that, if all your conditions go through, you did everything in your power to protect the privacy of your users & the security of your repository while still assisting the authorities.
- Compliance with the authorities, which avoids issues due to refusal of governmental orders.
### Cons:
- Major security risk by implementing any backdoor, regardless of how carefully or cleverly it is put in.
- Major reputation risk by implementing a backdoor without informing clients, especially if data is collected without their knowledge.
### Expected Dialogue:
- Me: "Okay, I see you guys are serious about this; I am willing to work with you. However, my client's privacy, the repository's security, and my reputation as a developer are essential. Therefore, I would like to discuss a list of conditions and requirements for this assignment before any line of code is written."
- Authority Contact: "We could say the same for you, but don't expect everything just because you own it. The meeting will be in a few days. Be ready for more details soon."
- Me: "Sure thing. See you then."
### Verse: Romans 13:1
Let every person be subject to the governing authorities. For there is no authority except from God, and those that exist have been instituted by God.
### First Principle: Proceeding with caution
- This project has the possibility of stopping terrible evil but requires immense risk. Therefore, as many variables as possible should be accounted for in order to respect others and yourself.
# Response 3: Tell them to create their own backdoor and convince your clients to use it.
### Reasoning
Implementing a backdoor induces too many security and reputation risks. Since this code is an open-source repository, a solution is to tell them to copy all the code, implement their own back door, and attempt to convince or force your clients to use the new code for a specified time. As stated in the notes of the question, no company owns the code, and it is right there for them to edit.
- For example, if the repository is a program to make image transferring faster and with less quality reduction reliable across devices with different operating systems, a reasonable suggestion would be to go to the phone companies and force them to use the backdoor code. If they can't do that, there should be no reason to create a backdoor in the base code without my client's knowledge.
Again, considering the repository's success, it's not unreasonable to assume you could hire a lawyer to assist in this, but very unlikely.
### Pros:
- Possible complete avoidance of the problem, making them do it since all the resources are available.
- No danger to the security of the code and your reputation by creating a backdoor
### Cons:
- Not a solution for every situation. They could have exact reasons why:
	- You specifically need to write the code
	- Going to clients is unreasonable for the investigation
- It puts you more out of control of what they try to do with your code.
- Reputation could still be damaged by association of "this code contained a backdoor," especially if things go wrong.
### Expected Dialogue:
- Authority Contact: "Now that you have reviewed the documents, will you begin developing the code for our investigation?"
- Me: "With all due respect, this is an open-source project. My client's privacy, the repository's security, and my reputation as a developer are vital to me. I do not want to tarnish them by implementing a hidden backdoor, regardless of whether it's from the government. All of the code is right there for you to use; develop the backdoor yourself and convince my clients to use it."
- Authority contact: "We will provide further reasoning later. That solution may not be an option or the most optimal method of collecting evidence."
### Verse: 2 Corinthians 6:14
Do not be unequally yoked with unbelievers. For what partnership has righteousness with lawlessness? Or what fellowship has light with darkness?
### First Principle: Open-source principles
- Your code is right there for them to copy and develop how they wish. Let them do it themselves.
# My Choice:
* Of all the options presented, I would choose option #3. With the open-source code, asking them to develop the backdoor is not unreasonable since they have everything they need to make their own backdoor and the power to force others to use it.
* However, I also understand that I do not have any open-source development experience, meaning it may not be an option and could lead to NUMEROUS other problems.
* In addition, I find response #1 improbable to be allowed; the authorities would not want you discussing the details of this request. As for reason #2, I do not believe the authorities would agree to reasonable demands for their evidence collection. Finally, due to the popularity of the code, there is a good chance my reputation as a developer will be obliterated because SOMEONE will find the backdoor.
* Therefore, deferring the responsibility to them is the best option since it is an open-source project.
