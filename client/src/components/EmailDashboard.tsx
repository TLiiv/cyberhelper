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
    isRead: false,
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
    isRead: false,
  },
];
//Design https://designshack.net/wp-content/uploads/Email-App-Dashboard-UI-Kit-Figma-Template-1.webp ?
const EmailDashboard: React.FC = () => {
  const [selectedEmail, setSelectedEmail] = useState<Email | null>(null);

    return (
       <Flex height="100vh">
      {/* Sidebar */}
      <VStack
        width="250px"
        align="stretch"
        bg="gray.700"
        height="100vh"
        p={4}
      >
        <Heading size="lg" color="white" textAlign="center">Inbox</Heading>
        <Button colorScheme="gray" variant="solid">Inbox</Button>
        <Button colorScheme="gray" variant="solid">Sent</Button>
        <Button colorScheme="gray" variant="solid">Trash</Button>
      </VStack>

      {/* Main Content Area */}
            <Flex flex="1" flexDirection="column">
                
        <Flex bg="gray.200" p={4} alignItems="center"  >
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

      {/* Email List */}
        <Flex flex="1">
          <VStack width="300px" p={4} align="stretch" bg="gray.200">
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
                <Box mt={4} p={4} bg="gray.600" borderRadius="md">
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
  );
};

export default EmailDashboard;