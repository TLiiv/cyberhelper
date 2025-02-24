import { useState } from "react";
import { Box,Flex,VStack,Text,Button,Heading, Input, Card, IconButton } from "@chakra-ui/react";
import { LuClipboardPen, LuMail, LuMailCheck, LuTrash2 } from "react-icons/lu";

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
    isRead: false,
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

  const user ="User"

  return (
    <Flex height="100vh" width="100%" bg="gray.300" borderRadius="4xl">
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
          bg="gray.300" 
          zIndex="1"
        >
          
          <Flex flexDirection="column" gap={2} pl={10} pt={6}> 
          <Heading pt={2} pb={4} size="2xl" color="teal.600" textAlign="center"> <Flex align="center" justify="center" gap={2}>
              <LuMail style={{ fontSize: "1.6em" }}/>
              <Text as="span" color="teal.600">CyberMail</Text>
            </Flex>
          </Heading>
          <Heading  pb={4} size="2xl" color="white" textAlign="center"> Hello <Text as="span" color="teal.600">{user}</Text></Heading>
          <Button   colorPalette="teal" variant="solid" size="xl" rounded="2xl">Uus Mail</Button>
          <IconButton   variant="ghost" size="lg" _hover={{ bg: "none" }}> <LuMail/><Text>Sisendkaust</Text></IconButton>
          <IconButton  disabled variant="ghost" size="lg" _hover={{ bg: "none" }}><LuMailCheck/> <Text>Saadetud</Text></IconButton>
          <IconButton  disabled variant="ghost" size="lg" _hover={{ bg: "none" }}><LuClipboardPen/> <Text>Mustand</Text></IconButton>
          <IconButton  disabled variant="ghost" size="lg" _hover={{ bg: "none" }}><LuTrash2 /><Text>Prügikast</Text></IconButton>
          </Flex>
        </VStack>

        {/* Main Content (Navbar + Emails) */}
        <Flex width="80%" marginLeft="auto" flexDirection="column" borderRadius="4xl" overflow="hidden">
          {/* Navbar */}
          <Flex bg="gray.100" p={4} alignItems="center" borderTopRadius="4xl">
            <Input
                placeholder="Otsi meile..."
                width="25%"
                bg="white"
                color="black"
                borderRadius="xl"
                disabled
              />
          </Flex>

          {/* Email List*/}
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
        </Flex>
      </Flex>
    </Flex>
  );
};

export default EmailDashboard;

