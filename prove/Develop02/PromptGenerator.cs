using System;

public class PromptGenerator {
    public List<string> _prompts {get; set;}

    public PromptGenerator() {
        _prompts = new List<string> {
        "How do your co-workers and supervisors recognize your strengths?",
        "How does work fulfill you? Does it leave you wanting more?",
        "What part of your workday do you most enjoy?",
        "What about your work feels real, necessary, or important to you?",
        "Do you see yourself in the same job in 10 years?",
        "What are your career ambitions?",
        "What three things can help you begin working to accomplish those goals?",
        "What can you do to improve your work performance?",
        "What does your work teach you? Does it offer continued opportunities for learning and growth?",
        };
    }

    public string GenerateRandomPrompt() {
     
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

    }
}
