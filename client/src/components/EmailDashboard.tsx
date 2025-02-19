import { useState } from "react";
import { Box,Flex,VStack,Text,Button,Heading, Input, Card } from "@chakra-ui/react";

interface Email {
  id: number;
  sender: string;
  subject: string;
  body: string;
  isRead: boolean;
}

const emails: Email[] = [
  {
    id: 1,
    sender: "support@paypal.com",
    subject: "Urgent: Your account has been limited!",
    body: "We've detected unusual activity. Please verify your account immediately.",
    isRead: true,
  },
  {
    id: 2,
    sender: "no-reply@amazon.com",
    subject: "Your order has been shipped!",
    body: "Your recent order has been shipped and will arrive soon.",
    isRead: true,
  },
  {
    id: 3,
    sender: "security@bank.com",
    subject: "Security Alert: Unauthorized login attempt",
    body: "We detected a login attempt from an unknown device.",
    isRead: true,
  },
];
//Design https://designshack.net/wp-content/uploads/Email-App-Dashboard-UI-Kit-Figma-Template-1.webp ?
const EmailDashboard: React.FC = () => {
  const [selectedEmail, setSelectedEmail] = useState<Email | null>(null);

  return (
    <Flex height="100vh" width="100%" bg="gray.700" borderRadius="4xl">
      {/* Sidebar (Full Screen Background) */}
      <Flex width="100vw" height="100vh" position="relative" borderRadius="4xl">
        {/* Sidebar Navigation (Fixed on Left) */}
        <VStack 
          borderRadius="4xl"
          width="250px" 
          align="stretch" 
          height="100vh" 
          position="absolute" 
          left="0" 
          bg="gray.700" 
          zIndex="1"
        >
          <Heading size="lg" color="white" textAlign="center">Inbox</Heading>
          <Button colorPalette="gray" variant="solid">Inbox</Button>
          <Button colorPalette="gray" variant="solid">Sent</Button>
          <Button colorPalette="gray" variant="solid">Trash</Button>
        </VStack>

        {/* Main Content (Navbar + Emails) */}
        <Flex width="80%" marginLeft="auto" flexDirection="column" borderRadius="4xl" overflow="hidden">
          {/* Navbar */}
          <Flex bg="gray.200" p={4} alignItems="center" borderTopRadius="4xl">
            <Heading size="md">PhishingMailbox</Heading>
            <Flex flex={1} justifyContent="center">
              <Input
                placeholder="Search emails..."
                width="60%"
                bg="white"
                color="black"
                borderRadius="md"
              />
            </Flex>
          </Flex>

          {/* Email List*/}
          <Flex flex="1" >
            <VStack width="350px" p={4} align="stretch" bg="gray.200" >
              {emails.map((email) => (
                <Card.Root
                  key={email.id}
                  p={3}
                  borderRadius="xl"
                  bg={email.isRead ? "gray.300" : "gray.400"}
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
            <Box flex="1" p={6} bg="gray.200">
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
        </Flex>
      </Flex>
    </Flex>
  );
};

export default EmailDashboard;

