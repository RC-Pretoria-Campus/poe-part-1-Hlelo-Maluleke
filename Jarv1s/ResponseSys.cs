using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Jarv1s
{
    public class ResponseSys
    {
        // A dictionary to store user input keywords and corresponding responses
        private Dictionary<string, string> responses = new Dictionary<string, string>
        {
            { "phishing", "Phishing is a social engineering attack where scammers impersonate trusted entities to steal credentials. Watch for suspicious emails! Phishing attacks use fake emails or websites to trick you. Never click unknown links or provide personal info via email." },
            { "hello", "Hello! How can I assist you today?" },
            { "hi", "Hello! How can I assist you today?" },
            { "hey", "Hey there! What would you like to know?" },
            { "good morning", "Good morning! Ready to learn about cybersecurity?" },
            { "good afternoon", "Good afternoon! How can I help you?" },
            { "how are you", "I'm doing great, thanks for asking! How can I assist you?" },
            { "what's up", "Not much! Just here to help. What's on your mind?" },
            { "thanks", "You're welcome! If you have any more questions, feel free to ask." },
            { "thank you", "You're welcome! Happy to help!" },
            { "thanks for", "Anytime! I'm here to help." },
            { "cool", "Glad you think so! Any other questions?" },
            { "awesome", "Awesome! I love the enthusiasm. What else would you like to know?" },
            { "interesting", "Right? Cybersecurity is a fascinating field! Want to learn more?" },
            { "why", "Good thinking! That's an important question." },
            { "ok", "Great! Anything else you'd like to know?" },
            { "alright", "Perfect! Let's continue." },
            { "yes", "Excellent! What's next?" },
            { "no", "I understand. Feel free to ask anything else!" },
            { "help", "I can help with: encryption, malware, firewall, vulnerability, password security, ransomware, phishing, DDoS, authentication, network security, data breaches, antivirus, social engineering, two-factor auth, and software updates. Ask about any of these!" },
            { "can you do", "I can teach you about various cybersecurity topics! Try asking about threats, protection methods, or specific security concepts." },
            { "capabilities", "I'm knowledgeable about cybersecurity topics. Ask me anything from basic concepts to advanced threats!" },
            { "threat", "There are many types of threats: DDoS attacks, Spoofing, Phishing, Malware, Ransomware, Viruses, Trojans, and Worms. Which one interests you?" },
            { "threats", "Cyber threats include: malware, ransomware, phishing attacks, DDoS, data breaches, social engineering, and more. Want details on any?" },
            { "attack", "Cyberattacks vary widely. Common ones include phishing, DDoS, malware distribution, and credential theft. What would you like to know?" },
            { "protect", "Protection involves multiple layers: strong passwords, antivirus software, firewalls, updates, and user awareness. What aspect interests you?" },
            { "safe", "Stay safe by: using strong passwords, enabling 2FA, keeping software updated, avoiding suspicious links, and using antivirus software." },
            { "secure", "Security is about combining technology and good practices. Encryption, firewalls, and awareness are key components." },
            { "encryption", "Encryption is the process of converting information into code to prevent unauthorized access. It uses algorithms to secure data during storage and transmission." },
            { "encrypt", "Encryption protects your data by converting it into unreadable code. Only those with the key can decrypt it." },
            { "malware", "Malware is malicious software designed to harm or exploit your computer. Types include viruses, trojans, worms, spyware, and ransomware." },
            { "virus", "A virus is malware that replicates itself and spreads to other computers. It can corrupt files and damage your system." },
            { "trojan", "A trojan is disguised malware that appears legitimate but performs harmful actions once installed. It can steal data or give attackers access." },
            { "firewall", "A firewall is a network security system that monitors and controls incoming and outgoing traffic. It acts as a barrier between your device and the internet." },
            { "vulnerability", "A vulnerability is a weakness in software or hardware that attackers can exploit. Regular updates patch these weaknesses." },
            { "weakness", "Security weaknesses come from outdated software, poor passwords, and user error. Addressing them is crucial for protection." },
            { "exploit", "An exploit is a technique attackers use to take advantage of vulnerabilities. Prevention includes updating software and security awareness." },
            { "password", "Strong passwords should be at least 12 characters long, include uppercase, lowercase, numbers, and special characters. Never reuse passwords!" },
            { "password security", "Use unique, complex passwords for each account. Enable password managers and change passwords if compromised." },
            { "weak password", "Weak passwords are easily guessed. Avoid simple patterns, birthdays, or dictionary words. Use a mix of character types instead." },
            { "ransomware", "Ransomware encrypts your files and demands payment for decryption. Prevention: regular backups, never pay, and keep software updated." },
            { "ddos", "A DDoS attack floods a server with massive traffic, making it unavailable. Types: volumetric, protocol, and application layer attacks." },
            { "dos attack", "A DoS attack aims to make a service unavailable. DDoS involves multiple attackers. Both are serious threats." },
            { "authentication", "Authentication verifies your identity. Multi-factor authentication (MFA) requires multiple verification methods for better security." },
            { "mfa", "Multi-factor authentication adds extra layers: something you know (password), have (device), or are (biometric). Much more secure!" },
            { "network", "Network security protects data in transit. Use VPNs, firewalls, encrypted protocols, and secure configurations." },
            { "vpn", "A VPN encrypts your internet traffic and masks your IP address. It provides privacy and security on public networks." },
            { "breach", "A data breach occurs when unauthorized parties access confidential information. Monitor accounts and enable security alerts." },
            { "data breach", "When data is compromised, hackers gain access to personal or business information. Always use strong passwords and 2FA." },
            { "antivirus", "Antivirus software detects and removes malicious programs. Keep it updated and perform regular scans." },
            { "antivirus software", "Good antivirus provides real-time protection against malware. Pair it with firewalls and safe browsing habits." },
            { "cyber", "Cybersecurity protects computers and networks from digital attacks. Practice good habits: update software, strong passwords, cautious browsing." },
            { "cybersecurity", "Cybersecurity is the practice of protecting systems and data from digital attacks. It combines technology, processes, and people." },
            { "security", "Security requires multiple layers: technology (firewalls, encryption), policies, and user awareness." },
            { "social engineering", "Social engineering manipulates people into divulging confidential information. Stay alert and verify requests through official channels." },
            { "social engineer", "These attackers use psychology and manipulation rather than technical skills. Don't share personal info with unknown contacts." },
            { "two factor", "Two-factor authentication (2FA) requires two verification methods. It significantly increases security compared to passwords alone." },
            { "2fa", "2FA adds an extra security layer. Use authenticator apps or SMS verification for better protection." },
            { "update", "Software updates patch security vulnerabilities. Enable automatic updates to protect against known exploits." },
            { "patch", "Security patches fix vulnerabilities. Apply updates promptly to protect your system from exploits." },
            { "hacker", "Hackers exploit vulnerabilities for various reasons: financial gain, data theft, or disruption. Protect yourself with security best practices." },
            { "hack", "Hacking can range from minor mischief to serious cybercrime. Defend yourself with updates, strong passwords, and awareness." },
            { "privacy", "Privacy protects your personal information from unauthorized access. Use encrypted messaging, VPNs, and manage privacy settings." },
            { "credential", "Credentials (usernames/passwords) are prime targets for attackers. Use unique, strong passwords and never share them." },
            { "identity theft", "Identity theft occurs when someone uses your personal info fraudulently. Protect yourself with strong passwords and credit monitoring." },
            { "backup", "Regular backups protect you from ransomware and data loss. Store copies offline or in secure cloud storage." },
            { "recovery", "Having a disaster recovery plan helps restore systems after attacks. Regular backups are essential!" },
            { "incident", "A security incident is any breach or attack. Report it immediately, isolate affected systems, and seek professional help." },
            { "monitoring", "Security monitoring detects suspicious activity in real-time. Alerts help you respond quickly to threats." },
            { "access control", "Access control limits who can use systems or data. Use strong authentication and principle of least privilege." },
            { "compliance", "Compliance means meeting security regulations and standards. Important for businesses handling sensitive data." },
            { "framework", "Security frameworks provide guidelines for protection. Examples: NIST Cybersecurity Framework, ISO 27001." },
            { "policy", "Security policies define how to protect data and systems. They're crucial for consistent security practices." },
            { "training", "Security awareness training helps employees recognize and avoid threats. Regular training reduces human error." },
            { "awareness", "Security awareness means understanding threats and best practices. Stay informed to protect yourself!" },
            { "risk", "Security risk is the potential for loss from threats. Assess risks and implement appropriate controls." },
            { "threat actor", "Threat actors are individuals or groups performing cyberattacks. They range from script kiddies to nation-states." },
            { "zero day", "A zero-day vulnerability is unknown to the software vendor. Attackers exploit it before a patch exists." },
            { "who are you", "I'm Jarvis, your cybersecurity educational assistant! I'm here to teach you about digital threats and protection." },
            { "your name", "I'm Jarvis! Nice to meet you. What would you like to learn about cybersecurity?" },
            { "purpose", "My purpose is to educate you about cybersecurity concepts, threats, and best practices." },
            { "information", "I can provide detailed information on cybersecurity topics. What would you like to know?" },
            { "detail", "I'm happy to go into detail! Ask a specific question and I'll explain thoroughly." },
            { "example", "Great idea! I can provide examples. What topic would you like an example of?" },
            { "practice", "Good cybersecurity practice includes: strong passwords, regular updates, backups, and user awareness." },
            { "best practice", "Best practices include: strong authentication, regular updates, data backups, and security awareness." },
            { "tip", "Here's a security tip: Use passphrases instead of passwords—they're longer and more secure!" },
            { "advice", "My advice: prioritize strong passwords, enable 2FA, keep software updated, and stay aware of phishing attempts." },
            { "recommend", "I recommend implementing multiple security layers: firewalls, encryption, strong authentication, and regular monitoring." },
            { "suggestion", "A practical suggestion: start with strong passwords and 2FA, then learn about other security measures." },
        };
        // Method to process user input and return appropriate responses
        public string UserResponse(string userInput)
        {
            userInput = userInput.ToLower();
            if (string.IsNullOrEmpty(userInput)) {
                return "Please enter a valid input.";
            }

            // Check for exit command first
            if (userInput == "exit")
            {
                return "exit";
            }

            foreach (var response in responses)
            {
                if (userInput.Contains(response.Key))
                {
                    return response.Value;
                }
            }
            return "I'm sorry, I don't understand. Can you please rephrase?";
        }
        // Method to create a typing effect when displaying responses
        public static void TypingEffect(string text, int delayMs = 20)
        {
            foreach (char character in text)
            {
                Console.Write(character);
                Thread.Sleep(delayMs);
            }
            Console.WriteLine();
        }
    }
}

