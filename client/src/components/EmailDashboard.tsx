import { useState } from "react";
import { Box,Flex,VStack,Text,Button,Heading, Input } from "@chakra-ui/react";

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

const EmailDashboard: React.FC = () => {
  const [selectedEmail, setSelectedEmail] = useState<Email | null>(null);

    return (
       <Box height="100vh" display="flex" flexDirection="column">
      {/* Navbar */}
      <Flex bg="gray.800" p={4} color="white" alignItems="center">
        <Heading size="2xl">PhisingMailbox</Heading>
        <Flex flex={1} justifyContent="center">
          <Input
            placeholder="Search emails..."
            width="60%"
            bg="white"
            color="black"
            borderRadius="md"
          />
          {/* <IconButton aria-label="Search" icon={<FaSearch />} ml={2} /> */}
          <Text aria-label="Search" ml={2} />
        </Flex>
      </Flex>
    <Flex height="100vh">
      {/* Sidebar */}
        <VStack
        width="250px"
        align="stretch"
        bg="gray.800"
      >
        <Heading size="lg" textAlign="center">Inbox</Heading>
        <Button >Inbox</Button>
        <Button >Sent</Button>
        <Button >Trash</Button>
      </VStack>

      {/* Email List */}
      <VStack width="300px" p={4} align="stretch" bg="gray.300" >
        <Heading size="sm">Emails</Heading>
        {emails.map((email) => (
          <Box
            key={email.id}
            p={3}
            borderRadius="md"
            bg={email.isRead ? "gray.300" : "gray.800"}
            shadow="md"
            cursor="pointer"
            onClick={() => setSelectedEmail(email)}
          >
            <Text fontWeight="bold">{email.sender}</Text>
            <Text>{email.subject}</Text>
          </Box>
        ))}
      </VStack>


      {/* Email Preview */}
      <Box flex="1" p={6} bg="gray.300">
        {selectedEmail ? (
          <>
            <Heading size="md">{selectedEmail.subject}</Heading>
            <Text fontSize="sm" color="gray.500">
              From: {selectedEmail.sender}
            </Text>
            <Box mt={4} p={4} bg="gray.800" borderRadius="md">
              <Text>{selectedEmail.body}</Text>
            </Box>
          </>
        ) : (
          <Text>Select an email to preview</Text>
        )}
      </Box>
    </Flex>
</Box>
  );
};

export default EmailDashboard;