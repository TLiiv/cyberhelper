import EmailDashboard from "@/components/Email/EmailDashboard";
import {
  Box,
  Button,
  Dialog,
  Portal,
  Text,
  DialogBody,
  DialogContent,
  DialogHeader,
  DialogTitle,
  DialogBackdrop,
  DialogPositioner,
  Theme,
  VStack,
  Input,
} from "@chakra-ui/react";
import { useState } from "react";

const TestPage: React.FC = () => {
  const [username, setUsername] = useState("");
  const [testStarted, setTestStarted] = useState(false);

  const handleStartTest = () => {
    if (username.trim()) {
      setTestStarted(true);
    }
  };

  return (
    <Box maxW="1680px" mx="auto" px={4} position="relative">
      <Theme appearance="light" borderRadius="4xl">
        {!testStarted && (
          <Dialog.Root
            open
            modal
            preventScroll
            closeOnEscape={false}
            closeOnInteractOutside={false}
          >
            <Portal>
              <DialogBackdrop />
              <DialogPositioner>
                <DialogContent borderRadius="2xl" bg="white" maxW="lg" p={6}>
                  <DialogHeader>
                    <DialogTitle
                      fontSize="2xl"
                      fontWeight="bold"
                      color="gray.800"
                    >
                      Tere tulemast testile!
                    </DialogTitle>
                  </DialogHeader>
                  <DialogBody color="gray.800">
                    <VStack align="stretch">
                      <Text>
                        Enne alustamist sisesta oma nimi ja vajuta „Alusta
                        testi”.
                      </Text>
                      <Input
                        placeholder="Sisesta oma nimi"
                        value={username}
                        onChange={(e) => setUsername(e.target.value)}
                      />
                      <Button
                        colorScheme="teal"
                        onClick={handleStartTest}
                        disabled={!username.trim()}
                      >
                        Alusta testi
                      </Button>
                    </VStack>
                  </DialogBody>
                </DialogContent>
              </DialogPositioner>
            </Portal>
          </Dialog.Root>
        )}

        {testStarted && <EmailDashboard username={username} />}
      </Theme>
    </Box>
  );
};

export default TestPage;
