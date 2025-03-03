import { useState, useEffect } from "react";
import { Box, Button, VStack, Text, Heading, Container, Card, Flex } from "@chakra-ui/react";
import axios from "axios";


interface Email {
  id: number;
  sender: string;
  subject: string;
  body: string;
  isPhishing: boolean;
  isRead: boolean;
}


// const fakeEmails: Email[] = [
//   {
//     id: 1,
//     sender: "support@paypal.com",
//     subject: "Urgent: Your account has been limited!",
//     body: "We've detected unusual activity. Please verify your account immediately by clicking the link below.",
//     isPhishing: true,
//     isRead: true,
//   },
//   {
//     id: 2,
//     sender: "no-reply@amazon.com",
//     subject: "Your order has been shipped!",
//     body: "Your recent order has been shipped and will arrive soon. Track your package here.",
//     isPhishing: false,
//     isRead: true,
//   },
//   {
//     id: 3,
//     sender: "security@bankofamerica.com",
//     subject: "Security Alert: Unauthorized login attempt",
//     body: "We detected a login attempt from an unknown device. If this wasn’t you, reset your password immediately.",
//     isPhishing: true,
//     isRead: false,
//   }
// ];

const EmailInbox = () => {
  const [emails, setEmails] = useState<Email[]>([]);
  const [currentEmail, setCurrentEmail] = useState<Email | null>(null);
  const [selectedEmail, setSelectedEmail] = useState<Email | null>(null);

  useEffect(() => {
    axios.get<Email[]>("https://localhost:7225/api/Emails/random")
      .then((response) => {
        setEmails(response.data)
      })
      .catch((error) => {
        console.error("Error fetching emails:", error);
      });
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
    <>
    <Flex flex="1" >
            <VStack width="350px" p={4} align="stretch" bg="gray.100" >
              {emails.map((email) => (
                <Card.Root
                  _hover={{ bg: "gray.100" }}
                  key={email.id}
                  p={3}
                  borderRadius="lg"
                  bg={email.isRead ? "gray.100" : "gray.200"}
                  shadow="md"
                  cursor="pointer"
                  onClick={() => setSelectedEmail(email)}
                >
                  <Card.Title fontWeight="bold">{email.sender}</Card.Title>
                  <Card.Description>{email.subject}</Card.Description>
                </Card.Root>
              ))}
            </VStack>
            {/* Email Preview */}
            <Box flex="1" p={6} bg="gray.100">
              {selectedEmail ? (
                <>
                  <Heading size="md">{selectedEmail.subject}</Heading>
                  <Text fontSize="sm" color="gray.500">
                    From: {selectedEmail.sender}
                  </Text>
                  <Box mt={4} p={4} bg="gray.600" borderRadius="lg">
                    <Text>{selectedEmail.body}</Text>
                  </Box>
                </>
              ) : (
                <Text>Select an email to preview</Text>
              )}
            </Box>
      </Flex>
    </>
  );
};

export default EmailInbox;
