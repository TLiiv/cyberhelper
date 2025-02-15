import { useState, useEffect } from "react";
import { Box, Button, VStack, Text, Heading, Container, Card } from "@chakra-ui/react";

interface Email {
  id: number;
  sender: string;
  subject: string;
  body: string;
  isPhishing: boolean;
}

const fakeEmails: Email[] = [
  {
    id: 1,
    sender: "support@paypal.com",
    subject: "Urgent: Your account has been limited!",
    body: "We've detected unusual activity. Please verify your account immediately by clicking the link below.",
    isPhishing: true,
  },
  {
    id: 2,
    sender: "no-reply@amazon.com",
    subject: "Your order has been shipped!",
    body: "Your recent order has been shipped and will arrive soon. Track your package here.",
    isPhishing: false,
  },
  {
    id: 3,
    sender: "security@bankofamerica.com",
    subject: "Security Alert: Unauthorized login attempt",
    body: "We detected a login attempt from an unknown device. If this wasn’t you, reset your password immediately.",
    isPhishing: true,
  }
];

const EmailInbox = () => {
  const [emails, setEmails] = useState<Email[]>([]);
  const [currentEmail, setCurrentEmail] = useState<Email | null>(null);

  useEffect(() => {
    // Simulate API call with fake data
    setEmails(fakeEmails);
    setCurrentEmail(fakeEmails[0]);
  }, []);

  const handleUserResponse = (response: boolean) => {
    if (!currentEmail) return;
    
    console.log("User selected:", response ? "Phishing" : "Legit");

    // Load next email
    const nextIndex = emails.findIndex((e) => e.id === currentEmail.id) + 1;
    if (nextIndex < emails.length) {
      setCurrentEmail(emails[nextIndex]);
    } else {
      setCurrentEmail(null);
    }
  };

  return (
    <Container maxW="container.md" py={8}>
      <Heading textAlign="center" mb={6}>Phishing Awareness Training</Heading>
      {currentEmail ? (
        <Card.Root>
          <Card.Body>
            <Text fontSize="sm" color="gray.500">From: {currentEmail.sender}</Text>
            <Text fontSize="lg" fontWeight="bold">{currentEmail.subject}</Text>
            <Box my={4} p={3} bg="gray.100" borderRadius="md">
              <Text>{currentEmail.body}</Text>
            </Box>
            <VStack mt={4}>
              <Button colorScheme="green" onClick={() => handleUserResponse(false)}>Legit</Button>
              <Button colorScheme="red" onClick={() => handleUserResponse(true)}>Phishing</Button>
            </VStack>
          </Card.Body>
        </Card.Root>
      ) : (
        <Text textAlign="center" fontSize="xl">No more emails to review!</Text>
      )}
    </Container>
  );
};

export default EmailInbox;
